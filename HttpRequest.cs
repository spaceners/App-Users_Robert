using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace App_Users
{
    internal class HttpRequest
    {
        public string endPoint { get; set; }
        public string method { get; set; }
        public HttpRequest() 
        {
            endPoint = string.Empty;
            method = null;
        }

        public string makeRequest() 
        { 
            string response = string.Empty;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(endPoint);
            httpWebRequest.Method = method;

            try
            {
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream responseStream = httpWebResponse.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                response = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return response; 
        }
    }
}
