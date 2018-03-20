using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        EndPoint remote;
        byte[] data = new byte[1024];
        
        string input, stringData;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Keo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Kéo";
            byte[] sendData = Encoding.ASCII.GetBytes("0");
            server.SendTo(sendData, remote);

            byte[] recieveData = new byte[20];
            server.ReceiveFrom(recieveData, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(recieveData);
            
        }

        private void bnt_bua_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Búa";
            byte[] sendData = Encoding.ASCII.GetBytes("1");
            server.SendTo(sendData, remote);

            byte[] recieveData = new byte[20];
            server.ReceiveFrom(recieveData, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(recieveData);
        }

        private void bnt_bao_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bao";
            byte[] sendData = Encoding.ASCII.GetBytes("2");
            server.SendTo(sendData, remote);

            byte[] recieveData = new byte[20];
            server.ReceiveFrom(recieveData, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(recieveData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(
IPAddress.Parse("127.0.0.1"), 9050);
            remote = (EndPoint)ipep;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
