using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Message Service started ");
        }
    }
}