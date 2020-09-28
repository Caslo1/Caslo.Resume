using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Caslo.LearnTCP
{
    class ServerTCP
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 1321;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream , ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(4);

            while(true)
            {
                var listener = tcpSocket.Accept();
                var buffer = new byte[256];
                var size = 0;
                var date = new StringBuilder();

                do
                {
                    size = listener.Receive(buffer);
                    date.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (listener.Available > 0);

                Console.WriteLine(date);

                listener.Send(Encoding.UTF8.GetBytes("Вы отправили сообщение пользователю"));

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
        }
    }
}
