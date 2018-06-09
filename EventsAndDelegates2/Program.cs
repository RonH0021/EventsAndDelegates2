using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Cosmos"};

            var encoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // Subscriber
            var messageSerice = new MessageService();// subscriber


            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageSerice.OnVideoEncode;

            encoder.Encode(video);
        }
    }
}
