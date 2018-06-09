using System;

namespace EventsAndDelegates2
{
    public class MessageService
    {
        public void OnVideoEncode(object source, EventArgs args)
        {
            Console.WriteLine("Sending Message");
        }
    }
}