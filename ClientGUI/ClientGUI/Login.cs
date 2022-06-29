using System;
// socket programming
using System.Net;
using System.Net.Sockets;
// forms
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// encrypting and decrypting
using System.IO;
using System.Security.Cryptography;

namespace ClientGUI
{
    public partial class Login : Form
    {
        public static Socket clientSocket;
        public static byte[] bytes = new byte[1024];

        public Login()
        {
            InitializeComponent();
        }
        // client socket
        public void StartClient()
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[1];
            Console.WriteLine(ipAddress);
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 777);
            clientSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                Console.WriteLine("waiting to connect to the server");
                clientSocket.Connect(remoteEP);
                Console.WriteLine("Connected succefully to port 777");
                getMsg();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
       
        public static void sendMsg(string text)
        {
            byte[] msg = Encoding.UTF8.GetBytes(text);
            int bytesSent = clientSocket.Send(msg);
        }
        public static string getMsg()
        {
            int bytesReceived = clientSocket.Receive(bytes);
            string msg = Encoding.UTF8.GetString(bytes, 0, bytesReceived);
            Console.WriteLine(msg);
            return msg;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            StartClient();
        }


        // sign up 
        private void signupbtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
        // login
        private void loginbtn_Click(object sender, EventArgs e)
        {
            sendMsg("1");
            string username = this.ustxtbx.Text;
            string password = this.passtxtbx.Text;
            sendMsg(username);
            sendMsg(password);
            string response = getMsg();
            Console.WriteLine(response);

            if (response == "Loggin in")
            {
                MessageBox.Show("Welcome again!");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password are not valid, please try again!");
            }
            
        }
        
    }
}
