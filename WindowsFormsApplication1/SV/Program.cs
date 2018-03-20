using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SV
{
    class Program
    {

        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 9050);
            sock.Bind(ipe);

            EndPoint ep = ipe;
          
            Console.WriteLine("Waiting for a client...");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);
            Console.WriteLine("Message received from {0}:", Remote.ToString());

            byte[] recieveData = new byte[10];
            sock.ReceiveFrom(recieveData, ref ep);

            int clientResult = Convert.ToInt32(Encoding.ASCII.GetString(recieveData));
            while (true)
            {
                Random r = new Random();
                int svResult = r.Next(0, 3);

                if ((svResult == 0 && clientResult == 0) || (svResult == 1 && clientResult == 1) || (svResult == 2 && clientResult == 2))
                {
                    Console.WriteLine("{0} da chon", clientResult);
                    byte[] sendData = Encoding.ASCII.GetBytes("Hòa");
                    sock.SendTo(sendData, ep);
                }
                if ((svResult == 0 && clientResult == 1) || (svResult == 0 && clientResult == 2) || (svResult == 1 && clientResult == 2))
                {
                    byte[] sendData = Encoding.ASCII.GetBytes("Thắng");
                    sock.SendTo(sendData, ep);
                }
                if ((svResult == 2 && clientResult == 1) || (svResult == 3 && clientResult == 1) || (svResult == 3 && clientResult == 2) || (svResult == 3 && clientResult == 0))
                {
                    byte[] sendData = Encoding.ASCII.GetBytes("Thua");
                    sock.SendTo(sendData, ep);
                }
                else
                {
                    byte[] sendData = Encoding.ASCII.GetBytes("Dang Xu Ly");
                    sock.SendTo(sendData, ep);
                }
            }
            sock.Close();
            
        }
    }
}
