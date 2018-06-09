using System;

namespace EventsAndDelegates2
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mail was sent");
        }
    }
}