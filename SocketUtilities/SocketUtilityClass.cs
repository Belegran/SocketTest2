using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketUtilities
{
    
    public class Commands
    {
        public const String TIME = "TIME";
        public const String NUMBER_OF_CLIENTS = "NUMBER_OF_CLIENTS";
        public const String QUIT = "QUIT";
    }


    public class SocketUtilityClass
    {
        private TcpClient client;
        private NetworkStream ns;
        private StreamWriter sw;
        private StreamReader sr;

        public void WriteMessage(string s)
        {
            sw.WriteLine(s);
        }

        public string ReadMessage()
        {
            return sr.ReadLine();
        }

        public SocketUtilityClass(TcpClient client)
        {
            this.client = client;

        }

        public bool DataAvailable()
        {
            return ns.DataAvailable;
        }

        public void Open()
        {
            ns = client.GetStream();
            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);

            sw.AutoFlush = true;
        }

        public void Write(string msg)
        {
            sw.WriteLine();
        }

        public string Read()
        {
            return sr.ReadLine();
        }

        public void Close()
        {
            sr.Close();
            sw.Close();
            ns.Close();
        }
    }
}
