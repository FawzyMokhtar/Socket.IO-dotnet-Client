using SocketIOClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketIOClient_NET_WFA
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// The socket.io client instance.
        /// </summary>
        SocketIO client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WriteToLogs("Socket.IO Cleint (Windows Forms App)...");
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            // Discount from the server first, if the cleint was already connected.
            if (client != null)
            {
                WriteToLogs("First we gonna discount from the server...");
                await client.DisconnectAsync();
                client.Dispose();
            }

            WriteToLogs("Trying to connect to the server...");

            // Connect to the client.
            client = new SocketIO(txtServerUrl.Text.Trim());

            // Attach event handlers to the socket.io client instance.
            client.OnConnected += Client_OnConnected;
            client.OnDisconnected += Client_OnDisconnected;
            client.On("data", Client_OnData());

            try
            {
                // safely connect to the server.
                await client.ConnectAsync();
            }
            catch (Exception)
            {
                WriteToLogs("Faild to connect to the server...");
            }
        }

        private async void btnDiscount_Click(object sender, EventArgs e)
        {
            // Discount from the server only if the cleint was already initiated.
            if (client == null)
                return;

            WriteToLogs("Trying to discount from the server...");

            try
            {
                // safely discount from the server.
                await client.DisconnectAsync();
            }
            catch (Exception)
            {
                WriteToLogs("Faild to discount from the server...");
            }
        }

        private void Client_OnDisconnected(object sender, string e)
        {
            WriteToLogs($"Successfully discounted from the server at ({client.ServerUri})...");
        }

        private void Client_OnConnected(object sender, EventArgs e)
        {
            WriteToLogs($"Successfully connected to the server on ({client.ServerUri})...");
        }

        /// <summary>
        /// The OnData event handler.
        /// </summary>
        /// <returns></returns>
        private Action<SocketIOResponse> Client_OnData()
        {
            return (SocketIOResponse response) =>
            {
                var data = response.GetValue<dynamic>();
                WriteToLogs($"Server sent: {data}");
            };
        }

        /// <summary>
        /// Writes and appends the given message to the list of logs.
        /// </summary>
        /// <param name="message">The log message to be appended to the list of logs.</param>
        private void WriteToLogs(string message)
        {
            var lineIndicator = "● ";
            txtLogs.AppendText(txtLogs.Text == string.Empty ? $"{lineIndicator}{message}" : $"{Environment.NewLine}{lineIndicator}{message}");
        }
    }
}
