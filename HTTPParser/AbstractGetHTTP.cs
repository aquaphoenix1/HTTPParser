using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace HTTPParser
{
    abstract class AbstractGetHTTP
    {
        protected bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }

            return false;
        }

        public abstract string GetHTTPPage(string url);

        protected Socket ConnectSocket(string server, int port)
        {
            Socket s = null;
            IPHostEntry hostEntry;

            try
            {
                hostEntry = Dns.GetHostEntry(server);
            }
            catch
            {
                return null;
            }

            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint ipe = new IPEndPoint(address, port);
                Socket tempSocket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    var result = tempSocket.BeginConnect(ipe, null, null);

                    result.AsyncWaitHandle.WaitOne(1000, true);
                }
                catch
                {
                    continue;
                }

                if (tempSocket.Connected)
                {
                    s = tempSocket;

                    s.ReceiveTimeout = 5000;

                    break;
                }
            }
            return s;
        }
    }
}
