using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        // 1. Define a delgate:
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        
        // 2. Define an event based on that delegate:
        public event VideoEncodedEventHandler VideoEncoded;

        // 3. Raise the event
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...{0}", video.Title);
            Thread.Sleep(2000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
