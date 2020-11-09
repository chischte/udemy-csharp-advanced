namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "The Big Lebowsky" };
            var videoEncoder = new VideoEncoder();      // publisher
            var mailService = new MailService();        // subscriber 1
            var messageService = new MessageService();  // subscriber 2

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Add reference to subscriber
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
