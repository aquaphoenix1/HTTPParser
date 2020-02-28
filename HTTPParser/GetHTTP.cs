using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTPParser
{
    class GetHTTP : AbstractGetHTTP
    {
        private const int BUFFER_SIZE = 2048;

        private string GetHHTPPageWithoutSSL(Socket socket, StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Connection: Close");
            stringBuilder.AppendLine();
            var bytes = Encoding.GetEncoding(1251).GetBytes(stringBuilder.ToString());

            var resultHTML = string.Empty;

            socket.Send(bytes, bytes.Length, 0);

            var writer = new byte[BUFFER_SIZE];

            int reading;
            do
            {
                try
                {
                    reading = socket.Receive(writer, writer.Length, 0);
                }
                catch
                {
                    return "";
                }

                resultHTML += Encoding.GetEncoding(1251).GetString(writer, 0, reading);
            }
            while (reading == BUFFER_SIZE);

            return resultHTML;
        }

        private async Task<string> GetHTTPPageSSL(Uri uri, Socket socket, StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Connection: keep-alive");
            stringBuilder.AppendLine("User-Agent: CSharp");
            stringBuilder.AppendLine("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            stringBuilder.AppendLine("Accept-Encoding: gzip,deflate,sdch");
            stringBuilder.AppendLine("Accept-Language: en-US,en;q=0.8");
            stringBuilder.AppendLine("Accept-Charset: ISO-8859-1,utf-8;q=0.7,*;q=0.3");
            stringBuilder.AppendLine();

            var resultHTML = string.Empty;

            using (var networkStream = new NetworkStream(socket))
            {
                using (SslStream sslStream = new SslStream(networkStream, false,
new RemoteCertificateValidationCallback(ValidateServerCertificate), null))
                {
                    sslStream.AuthenticateAsClient(uri.Host);

                    var bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());

                    bytes = Encoding.UTF8.GetBytes("Hello from the client.<EOF>");

                    await sslStream.WriteAsync(bytes, bytes.Length, 0);

                    var writer = new byte[BUFFER_SIZE];

                    int reading;
                    do
                    {
                        try
                        {
                            reading = await sslStream.ReadAsync(writer, 0, writer.Length);
                        }
                        catch
                        {
                            return "";
                        }

                        resultHTML += Encoding.GetEncoding(1251).GetString(writer, 0, reading);
                    }
                    while (reading == BUFFER_SIZE);
                }
            }

            return resultHTML;
        }

        public override string GetHTTPPage(string url)
        {
            Uri uri;
            try
            {
                uri = new Uri(url);
            }
            catch
            {
                return "";
            }

            if (!uri.Scheme.Equals("http", StringComparison.OrdinalIgnoreCase) && !uri.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase))
            {
                return "";
            }

            var sb = new StringBuilder();

            sb.AppendLine(string.Format("GET {0} HTTP/1.1", uri.PathAndQuery));
            sb.AppendLine(string.Format("Host: {0}", uri.Host));

            /*var request = string.Format(
                @"GET {0} HTTP/1.1
Host: {1}
Connection: Сlose

",
                uri.PathAndQuery,
                uri.Host
                );*/

            using (var socket = ConnectSocket(uri.Host, uri.Port))
            {
                if (socket == null)
                {
                    return "";
                }

                string htmlText;

                if (uri.Scheme.Equals("http"))
                {
                    htmlText = GetHHTPPageWithoutSSL(socket, sb);
                }
                else
                {
                    htmlText = GetHTTPPageSSL(uri, socket, sb).Result;
                }

                return htmlText;
            }

            throw new Exception("Unknown Error");
        }
    }
}
