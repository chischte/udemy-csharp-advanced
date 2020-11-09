using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    
    public class VideoEncoder
    {
        // (1 + 2) Define an event based on EventHandler delegate:
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 3 Raise the event
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){Video=video});
            }
        }
    }
}
