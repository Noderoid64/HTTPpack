using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.Transport;

using Hello.Http;

using HttpVersion = Hello.Http.Model.HttpVersion;
using Hello.Http.Model;

namespace Hello
{

    class Program
    {
        const string ip = "91.223.123.241";
        const string port = "80";

        static void Main(string[] args)
        {

            HttpDatagram datagram = new HttpRequestDatagram(HttpMethods.GET, "/Hello/myUri", new HttpVersion(1,1));
            datagram.header = new HttpHeader();
            datagram.header.SetField(new HttpHeaderField("Host", new AcceptValue(new AcceptContentString("123.245.164.234"))));

            Console.WriteLine(datagram.GetString());


            //IPEndPoint destination = new IPEndPoint(IPAddress.Parse(ip), int.Parse(port));
            //Socket TcpSocket = new Socket(System.Net.Sockets.AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //TcpSocket.Connect(destination);
            //byte[] message = Encoding.ASCII.GetBytes("GET /csd-3.5/ HTTP/1.1\r\nHost: colorschemedesigner.com\r\n\r\n");
            //TcpSocket.Send(message);

            //message = new byte[1024]; 
            //StringBuilder builder = new StringBuilder();
            //int bytes = 0;
            //Console.WriteLine("Message has been send");

            //do
            //{
            //    bytes = TcpSocket.Receive(message, message.Length, 0);
            //    builder.Append(Encoding.ASCII.GetString(message, 0, bytes));
            //}
            //while (TcpSocket.Available > 0);
            //Console.WriteLine("ответ сервера: " + builder.ToString());

            //// закрываем сокет
            //TcpSocket.Shutdown(SocketShutdown.Both);
            //TcpSocket.Close();
            Console.ReadKey();
        }
    }
}
