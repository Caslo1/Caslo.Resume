using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Caslo.LearnUDP
{
    class SerUPD
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 1322;

            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);

                do
                {
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);

                udpSocket.SendTo(Encoding.UTF8.GetBytes("Сообщение отправлено"), senderEndPoint);

                Console.WriteLine(data);
            }
        }
    }
}
