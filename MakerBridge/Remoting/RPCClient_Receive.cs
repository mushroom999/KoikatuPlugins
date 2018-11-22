﻿using System;
using System.Threading;
using MessagePack;

namespace MakerBridge.Remoting
{
    static class RPCClient_Receive
    {
        private static IMessenger remoteObject;
        private static Action<MsgObject> messageAction;
        private static string serverName;
        private static int serverPort;
        private static volatile bool threadRunning = false;

        public static void Init(string name, int port, Action<MsgObject> action)
        {
            messageAction = action;
            serverName = name;
            serverPort = port;

            StartServer();
        }

        public static void StartServer()
        {
            if(!threadRunning)
            {
                new Thread(RefreshMessages).Start();
            }
            else
            {
                Console.WriteLine("[MakerBridge] Server already running");
            }
        }

        public static void StopServer()
        {
            threadRunning = false;
        }

        public static bool Status()
        {
            return threadRunning;
        }

        private static void RefreshMessages()
        {
            try
            {
                var requiredType = typeof(IMessenger);
                var url = $"tcp://localhost:{serverPort}/{serverName}";
                remoteObject = (IMessenger)Activator.GetObject(requiredType, url);

                Console.WriteLine("[MakerBridge] Starting client");
                threadRunning = true;
                remoteObject.ClearMessage();
            }
            catch(Exception)
            {
                Console.WriteLine("[MakerBridge] Server not found");
            }

            while(threadRunning)
            {
                try
                {
                    var msg = remoteObject.GetMessage();
                    if(msg != null)
                    {
                        var message = MessagePackSerializer.Deserialize<MsgObject>(msg);
                        messageAction(message);
                    }

                    Thread.Sleep(100);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine("ERROR: Old bug in MessagePack-CSharp (Duplicate type name within an assembly, issue #127)\n" +
                                      "Must use a fixed Assembly-CSharp-firstpass.dll for this to work with scriptloader in KK\n" + ex);
                    threadRunning = false;
                }
                catch(Exception)
                {
                    threadRunning = false;
                }
            }

            Console.WriteLine("[MakerBridge] Stopping client");
        }
    }
}
