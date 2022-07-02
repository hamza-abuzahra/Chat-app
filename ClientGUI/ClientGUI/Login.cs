using System;
// socket programming
using System.Net;
using System.Net.Sockets;
using System.Threading;
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
        public static Main main = new Main();
        public static Thread listen;
        public static Semaphore s = new Semaphore(0, 1);
        public static string[] idnames = {"hamza.abuzahra@bilgiedu.net", "abdul.hamed@bilgiedu.net", "al.alshareef@bilgiedu.net",
            "sena.yilmaz03@bilgiedu.net", "ali.allouche@bilgiedu.net", "ghassan.nasseir@bilgiedu.net", "cevdet.arat@bilgiedu.net",
            "di.sa@bilgiedu.net", "abdullah.alward@bilgiedu.net", "murat.oguz@bilgi.edu.tr", "Everyone"};
        public static bool flag = false;
        public static AES256 aes = new AES256();
        public Login()
        {
            s.Release();
            InitializeComponent();
        }
        // client socket
        public static void sendMsg(string text)
        {
            // encrypt the message:
            var encryptedMessage = EncryptMessage(text);
            // send the encrypted message
            Console.WriteLine(encryptedMessage);
            Console.WriteLine(text);
            byte[] msg = Encoding.UTF8.GetBytes(encryptedMessage);
            int bytesSent = clientSocket.Send(msg);

        }
        public static string getMsg()
        {
            
            Console.WriteLine("waiting for server");
            int bytesReceived = clientSocket.Receive(bytes);
            string msg = Encoding.UTF8.GetString(bytes, 0, bytesReceived);
            Console.WriteLine(msg);
            var decryptedMessage = DecryptMessge(msg);
            Console.WriteLine(decryptedMessage);
            return decryptedMessage;
        }
        public static void send(string text)
        {
            string response = getMsg();
            sendMsg(text);
        }
        public static string recieve()
        {
            string msg = getMsg();
            sendMsg("got it");

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
                s.WaitOne();
                string test = recieve();
                Console.WriteLine(test);
                string welcomemsg = recieve();
                s.Release();
                listen = new Thread(new ThreadStart(main.updateChat));
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
            s.WaitOne();
            send("1");
            string username = this.ustxtbx.Text;
            send(username);
            Console.WriteLine(username);
            string password = this.passtxtbx.Text;
            Console.WriteLine(password);
            send(password);
            string response = recieve();
            s.Release();
            Console.WriteLine(response);

            if (response == "Loggin in")
            {
                currentuser = username;
                MessageBox.Show("Welcome again!");
                this.Hide();
                if (currentuser == "superuser")
                {
                    Superuser su = new Superuser();
                    su.ShowDialog();
                }
                else
                {
                    listen.Start();
                    main.ShowDialog();
                }
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
            s.WaitOne();
            send("exit");
            send(currentuser);
            clientSocket.Close();
            flag = true;
            s.Release();
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
            var encryptedString = aes.Encrypt(text, key);
            return encryptedString;
        }
        public static string DecryptMessge(string text)
        {
            var key = getKey();
            var decryptedString = aes.Decrypt(text, key);
            return decryptedString;
        }
    }

}
