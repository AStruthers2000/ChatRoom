using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//818 by 547 for main chatroom
//518 by 347 for login screen
namespace ChatApp
{
    public partial class Chatroom : Form
    {
        public Chatroom() => InitializeComponent();

        TcpClient clientSocket = new TcpClient();

        string hostIP = "";
        string serverPassword = "";
        string username = "";

        private void lookForMessages()
        {
            Console.WriteLine("Looking for messages...");

            while (true)
            {
                Byte[] data = new Byte[100000];
                NetworkStream stream = clientSocket.GetStream();
                Int32 bytes = stream.Read(data, 0, data.Length);
                String responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                String from = responseData.Split('|')[0];
                String recvMsg = responseData.Split('|')[1];
                msg(from + ": " + recvMsg + "\n");
            }
        }

        private void send(string msg)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            hostIP = IPAddrTextbox.Text;
            serverPassword = ServerPasswordTextbox.Text;
            username = UsernameTextbox.Text;
            if (hostIP.Equals("") || serverPassword.Equals("") || username.Equals(""))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Please retry";
            }
            else
            {
                this.Size = new System.Drawing.Size(615, 445);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                LoginScreen.Visible = false;
                ChatroomMain.Visible = true;
                msg("Client Loading...");
                try
                {
                    this.Update();
                    clientSocket.Connect(hostIP, 12345);
                    new Thread(new ThreadStart(lookForMessages)).Start();
                    msg("Client Connected to Server...");
                    send(String.Concat(username, " ", serverPassword));
                }
                catch(System.Net.Sockets.SocketException)
                {
                    msg("Could Not Connect to Host...");
                    msg("Returning to Login Screen...");
                    this.Update();
                    System.Threading.Thread.Sleep(5000);
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
            }
        }

        string UserInputText = "";
        private void UserInputGetText()
        {
            UserInputText = UserInputTextBox.Text;
            UserInputTextBox.Clear();
            msg();
            //Send the message
            send(UserInputText);
        }

        private void UserInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!UserInputTextBox.Text.Equals(""))
                {
                    UserInputGetText();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;               
            }
        }

        private void UserInputSendButton_Click(object sender, EventArgs e)
        {
            if (!UserInputTextBox.Text.Equals(""))
            {
                UserInputGetText();
            }
        }

        private void msg()
        {
            ChatroomMainTextbox.Text += username + ": " + UserInputText.ToString() + "\n";
            ChatroomMainTextbox.SelectionStart = ChatroomMainTextbox.TextLength;
            ChatroomMainTextbox.ScrollToCaret();
        }
        private void msg(string message)
        {
            string text = message;
            ChatroomMainTextbox.Invoke(new Action(() => ChatroomMainTextbox.Text += text));
            ChatroomMainTextbox.Invoke(new Action(() => ChatroomMainTextbox.SelectionStart = ChatroomMainTextbox.TextLength));
            ChatroomMainTextbox.Invoke(new Action(() => ChatroomMainTextbox.ScrollToCaret()));
        }
    }
}
