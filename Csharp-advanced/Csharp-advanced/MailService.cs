using CsharpAdvanced;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpadvanced
{
    public class MailService
    {
        public void OnVideoEncodedMail(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailServices: sending a message..." + e.Video.Title);
        }
    }
}
