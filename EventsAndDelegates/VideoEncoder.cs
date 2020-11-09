using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
   public class VideoEncoder
    {
        // (1 + 2) Define an event based on EventHandler delegate:
        public event EventHandler VideoEncoded;

        // Raise the event
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
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
