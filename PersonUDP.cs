using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UserUDP
{
    class PersonUDP
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 1323;

            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            Console.WriteLine("Введите ваш псевдоним: ");
            var name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Введите сообщение:");
                var message = Console.ReadLine();

                var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1322);
                udpSocket.SendTo(Encoding.UTF8.GetBytes($"{name}: {message}"), serverEndPoint);

                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1322);

                do
                {
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);

                Console.WriteLine(data);
            }      
        }
    }
}
