using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace WifiArduinoLed
{
    public partial class Form1 : Form
    {
        TcpClient tcpArduino;
        Stream streamArduino;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpArduino = new TcpClient();
        }

        private void btnLedON_Click(object sender, EventArgs e)
        {
            byte[] ba = Encoding.ASCII.GetBytes("H\n");

            streamArduino.Write(ba, 0, ba.Length);

            int recu = streamArduino.ReadByte();
            lblRecu.Text = Convert.ToChar(recu).ToString() ;
            if (recu == 72) pictureBox1.Image = Image.FromFile(@"red-led-on-md.png");
        }

        private void btnLedOFF_Click(object sender, EventArgs e)
        {
            byte[] ba = Encoding.ASCII.GetBytes("L\n");

            streamArduino.Write(ba, 0, ba.Length);

            int recu = streamArduino.ReadByte();
            lblRecu.Text = Convert.ToChar(recu).ToString(); ;
            if (recu == 76) pictureBox1.Image = Image.FromFile(@"led-red-off-md.png");
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                tcpArduino.Connect("192.168.1.30", 5500);
                streamArduino = tcpArduino.GetStream();
                if (tcpArduino.Connected)
                {
                    MessageBox.Show("Connecté...");
                    btnLedOFF.Enabled = true;
                    btnLedON.Enabled = true;
                    btnMesures.Enabled = true;
                    btnConnexion.Enabled = false;
                }
                else MessageBox.Show("Impossible de connecter !");
            }
            catch
            {
                MessageBox.Show("Erreur de connection !");
            }
             
        }

        private void btnMesures_Click(object sender, EventArgs e)
        {
            byte[] ba = Encoding.ASCII.GetBytes("M\n");

            streamArduino.Write(ba, 0, ba.Length);
            var recu = new byte[10];
            streamArduino.Read(recu, 0, recu.Length);
            lblMesures.Text = Encoding.ASCII.GetString(recu);
        }


    }
}
