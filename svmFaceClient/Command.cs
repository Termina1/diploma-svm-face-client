using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace svmFaceClient
{
    class Command : IDisposable
    {
        public Command() {
            connect();
        }

        private Socket _sender;

        private Dictionary<String, String> getConfig() {
            var dict = new Dictionary<String, String>();
            dict["host"] = "127.0.0.1";
            dict["port"] = "7878";
            return dict;
        }

        private void connect() {
            var config = getConfig();
            var remoteEP = new IPEndPoint(IPAddress.Parse(config["host"]), Int32.Parse(config["port"]));
            _sender = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            _sender.Connect(remoteEP);

        }

        private int sendRaw(byte[] data) {
            _sender.Send(data);
            byte[] bytes = new byte[20];
            var result = _sender.Receive(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public int send(String cmd) {
            return sendRaw((Encoding.ASCII.GetBytes(cmd)));
        }

        public int send(Image img) {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return sendRaw(ms.ToArray());
        }

        public void Dispose() { }
    }
}
