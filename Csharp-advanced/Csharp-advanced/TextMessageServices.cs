using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAdvanced
{
    public class TextMessageServices
    {
        public void OnVideoEncodedTextMessage(object s, VideoEventArgs e)
        {
            Console.WriteLine("Message Services: sending a message..." + e.Video.Title);
        }

    }
}
