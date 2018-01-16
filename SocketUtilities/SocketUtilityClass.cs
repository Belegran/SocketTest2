using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketUtilities
{
    public class SocketUtilityClass
    {
        private TcpClient client;
        private NetworkStream ns;
        private StreamWriter sw;
        private StreamReader sr;

        public SocketUtilityClass(TcpClient client)
        {
            this.client = client;

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
