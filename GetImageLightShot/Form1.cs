using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetImageLightShot
{
    public partial class GetImage : Form
    {

        public GetImage()
        {
            InitializeComponent();
        }

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Get_Click(object sender, EventArgs e)
        {
            try
            {
                string numberlessUrl = URL.Text;
                string url = null;
                string a = null;
                List<string> urlList = new List<string>();
                for (int i = Int32.Parse(numStart.Text); i <= Int32.Parse(numEnd.Text); i++)
                {
                    url = numberlessUrl + i;
                    urlList.Add(url);
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All Files (*.)|*.";
                save.ShowDialog();
                
                
                for (int i = 0; i < urlList.Count; i++)
                {
                    WebClient client = new WebClient();
                    client.Headers.Add("user-agent", "Only a test!");
                    string html = client.DownloadString(urlList[i]);
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);


                    a = doc.DocumentNode.SelectSingleNode("//img[@id='screenshot-image']").GetAttributeValue("src", "default");
                    FileInfo fi = new FileInfo(a);
                    string extn = fi.Extension;
                    if (a != null)
                    {
                       
                      
                        DownloadRemoteImageFile(a,  Path.GetFullPath(save.FileName) + Guid.NewGuid() + extn);
                        log.Info("Fotoğraf indirme başarılı");
                    }
                    else
                    {   
                        continue;
                    }
                }


            }
            catch (Exception exception)
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(new Control(URL.Text), exception.Message);
                log.Error("Hata " + exception.Message);
                throw exception;
            }

            MessageBox.Show("OK");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private static void DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                 response.StatusCode == HttpStatusCode.Moved ||
                 response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download oit
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
