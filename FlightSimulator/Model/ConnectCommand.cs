using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    class ConnectCommand
    {
        TcpClient client;
        private static ConnectCommand m_Instance = null;
        public static ConnectCommand Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new ConnectCommand();
                }
                return m_Instance;
            }
        }

        private ConnectCommand()
        {
            isConnected = false;
        }


        private bool isConnected;
        public bool IsConnected
        {
            get;
            set;
        }

        public void ConnetAsClient()
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ApplicationSettingsModel.Instance.FlightServerIP),
                ApplicationSettingsModel.Instance.FlightCommandPort);
            client = new TcpClient();
            client.Connect(iPEndPoint);
            isConnected = true;
            Console.WriteLine("Command channel :You are connected");

        }

        public void DisConnect()
        {
            isConnected = false;
            client.Close();
        }

        public void Send(string message)
        {

        }

        private string[] ParseMessage(string message)
        {
            string[] commands;
            return commands = message.Split('\n');
        }

    }
}
