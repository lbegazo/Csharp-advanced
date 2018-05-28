using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CsharpAdvanced
{
    public class VideoEncoder
    {
        //1.-Define a delegate
        //2.-Define an event based on that delegate
        //3.-Raise an event

        //1.-Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //2.-Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            //3.-Raise an event
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
