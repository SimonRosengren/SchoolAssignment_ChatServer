using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5ChatServer
{
    class User
    {
        bool isActive = true; //Flag for update loop

        public string name;

        ServerForm serverFrom; //Reference to the server form

        Socket connection; //Like a reference to the socket we are given

        TextBox messageDisplayBox;

        //NetworkStream netwStream;

        //BinaryReader reader;

        //string response;

        //BinaryWriter writer;

        //Without name
        public User(ServerForm serverFrom, TextBox messageDisplayBox, Socket connection)
        {
            this.serverFrom = serverFrom;
            this.connection = connection;
            this.messageDisplayBox = messageDisplayBox;
        }

        //With name
        public User(ServerForm serverFrom, TextBox messageDisplayBox, Socket connection, string name)
        {
            this.serverFrom = serverFrom;
            this.connection = connection;
            this.messageDisplayBox = messageDisplayBox;
            this.name = name;
        }

        public void Run(object obj)
        {
            string str = string.Empty;

            while (isActive)
            {
                //Recievs message
                byte[] bytes = new byte[128];
                int i = connection.Receive(bytes);
                str = Encoding.UTF8.GetString(bytes);


                messageDisplayBox.BeginInvoke((Action)delegate() { messageDisplayBox.Text += str; });
                messageDisplayBox.BeginInvoke((Action)delegate() { messageDisplayBox.Text += "\r\n"; });

                //Sends it back
                i = connection.Send(bytes, SocketFlags.None);               
            }
        }
        /// <summary>
        /// Sets the loop-flag to false and there by
        /// returns the thread to the pool
        /// and so disconnecting the user
        /// </summary>
        public void DisconnectUser()
        {
            this.isActive = false;
        }
    }
}
