using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Caslo.UserTCP
{
    class UserServerTCP
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 1321;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Введите свой псевдоним");
            var name = Console.ReadLine();

            Console.WriteLine("Введите сообщение: ");
            var message = Console.ReadLine();

            var date = Encoding.UTF8.GetBytes($"{name}: {message}");

            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(date);

            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = tcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (tcpSocket.Available > 0);

            Console.WriteLine(answer.ToString());

            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();

            Console.ReadLine();
        }
    }
}
