using Csharpadvanced;
using System;

namespace CsharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Titanic" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new TextMessageServices(); //Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncodedMail;
            videoEncoder.VideoEncoded += messageService.OnVideoEncodedTextMessage;
            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
