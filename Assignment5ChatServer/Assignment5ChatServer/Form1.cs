using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Assignment5ChatServer
{
    public partial class ServerForm : Form
    {
        List<User> users; //List of all the connected clientsS

        Socket socket;

        public ServerForm()
        {
            InitializeComponent();

            users = new List<User>();

            ThreadPool.QueueUserWorkItem(Setup); //One threadpool-thread will listen

        }
        /// <summary>
        /// Runs infinite and is
        /// listening for new clients
        /// </summary>
        /// <param name="obj"></param>
        public void Setup(object obj)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 50000); //ipadress + port
            listener.Start(); //Starts the listener
            while (true)
            {
                messageDisplayBox.BeginInvoke((Action)delegate() { messageDisplayBox.Text += "Waiting for client...\r\n"; });

                //Listens for new clients
                socket = listener.AcceptSocket();

                //Get name of client
                byte[] bytes = new byte[128];
                int i = socket.Receive(bytes);
                string name = Encoding.UTF8.GetString(bytes);

                //Adds new client to the list
                User newUser = new User(this, messageDisplayBox, socket, name);
                users.Add(newUser);

                //Add to listbox
                userListBox.BeginInvoke((Action)delegate() { userListBox.Items.Add(newUser.name); });

                //Give the new user a thread from pool
                ThreadPool.QueueUserWorkItem(newUser.Run); //Köra från list?
                
                //Update displayBox
                messageDisplayBox.BeginInvoke((Action)delegate() { messageDisplayBox.Text += "New client connected...\r\n"; });
            }
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {

        }

        private void kickButton_Click(object sender, EventArgs e)
        {

            users[userListBox.SelectedIndex].DisconnectUser();
            userListBox.Items.RemoveAt(userListBox.SelectedIndex);
        }
    }
}
