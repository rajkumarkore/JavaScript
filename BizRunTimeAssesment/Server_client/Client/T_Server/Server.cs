using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace T_Server
{
    class Server
    {
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //The Stream on the other hand is used to read and write information from one place to another. For example FileStream is used to read and write to and from files the 
                                                                               //stream itself has a buffer which buffer when filled to its max size is flushed and the data in the stream is read or written.

        static void Main(string[] args)
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadLine();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server...");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100)); //Eval is used for unidirectional (readonly) data binding, while Bind is for bi-directional (editable) databinding.
            _serverSocket.Listen(1);//Eval is used in read only way... so only take the data and display it. Bind is user for two ways  databinding...

            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);

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


