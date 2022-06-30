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
        public static string currentuser = "";
        public Login()
        {
            InitializeComponent();
        }
        // client socket
        public static void sendMsg(string text)
        {
            // encrypt the message:
            var encryptedMessage = EncryptMessage(text);
            // send the encrypted message
            byte[] msg = Encoding.UTF8.GetBytes(encryptedMessage);
            int bytesSent = clientSocket.Send(msg);
        }
        public static string getMsg()
        {
            
            Console.WriteLine("waiting for server");
            int bytesReceived = clientSocket.Receive(bytes);
            string msg = Encoding.UTF8.GetString(bytes, 0, bytesReceived);
            var decryptedMessage = DecryptMessge(msg);
            Console.WriteLine(decryptedMessage);
            return msg;
        }
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
                clientSocket.Connect(remoteEP); // connection point and handshake complete
                // send client public key to server
                
                Console.WriteLine("Connected succefully to port 777");
                getMsg();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
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
            sendMsg(username);
            Console.WriteLine(username);
            string password = this.passtxtbx.Text;
            Console.WriteLine(password);
            sendMsg(password);
            string response = getMsg();
            Console.WriteLine(response);

            if (response == "Loggin in")
            {
                currentuser = username;
                MessageBox.Show("Welcome again!");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Username or Password are not valid, please try again!");
            }

        }
        // closing the form
        public static void handleClosing()
        {
            sendMsg("exit");
            sendMsg(currentuser);
            clientSocket.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
                Console.WriteLine(answer);
                if (answer == DialogResult.Yes)
                {
                    handleClosing();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private static string getKey()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            return key;
        }
        public static string EncryptMessage(string text)
        {
            var key = getKey();
            var encryptedString = AesOperation.EncryptString(key, text);
            return encryptedString;
        }
        public static string DecryptMessge(string text)
        {
            var key = getKey();
            var decryptedString = AesOperation.DecryptString(key, text);
            return decryptedString;
        }
    }

}
