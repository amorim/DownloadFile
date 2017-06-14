using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadLib
{
   public  class Downloader
    {
        public static void Download(string url,string location)
        {
          
            Console.WriteLine("Download Started");
            WebClient webClient = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            try
            {
                webClient.DownloadFileAsync(new Uri(url),  location);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Download Error :" + ex.Message.ToString());
            }
                 
        }

        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Debug.WriteLine(e.ProgressPercentage+" %");
        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Debug.WriteLine("Download completed!");
        }

    }
}
