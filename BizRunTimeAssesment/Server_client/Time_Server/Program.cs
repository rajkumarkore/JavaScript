﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Time_Server
{
    
    class Program
    {
        private static byte[] _buffer = new byte[1024];

        private static List<Socket> _clientSockets = new List<Socket>(); //client listener

        private static Socket _serverSocket = new Socket   //global deleration socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        static void Main(string[] args)
        {
            Console.Title = "Server"; 
            SetupServer();
            Console.ReadLine();
        }

        private static  void SetupServer() //cal the mtd setup server
        {
            Console.WriteLine("Setting up server...");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100)); //here bind the localinterfaces, 100 is port
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);//for a object state

        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);
            Console.WriteLine("Client connected...");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);
            Console.WriteLine("Text received: " + text);

            string response = string.Empty;

            if (text.ToLower() != "get time")
            {
                response = "Invalid request";
            }
            else
            {
                response = DateTime.Now.ToLongDateString();
            }
                byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongDateString());
                socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);


        }

        private static void SendCallback(IAsyncResult AR)
            {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
            }
    }
}
