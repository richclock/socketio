using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;

namespace socketio
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            socket= IO.Socket("http://localhost:3000");
            socket.On(Socket.EVENT_CONNECT, (data) => {
                if (data != null) {
                    MessageBox.Show(data.ToString());
                    Console.WriteLine(data);
                    //socket.Disconnect();
                }
            });

            //socket.On("deal", (data) =>
            //{
            //    MessageBox.Show(data.ToString());
            //    Console.WriteLine(data);
            //    //socket.Disconnect();
            //});
            socket.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            socket.Disconnect();
        }
    }
}
