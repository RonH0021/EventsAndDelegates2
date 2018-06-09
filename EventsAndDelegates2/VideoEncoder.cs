using System;
using System.Threading;

namespace EventsAndDelegates2
{
    public class VideoEncoder
    {
        //Setps to create an event
        //1 - Define a delegate
        //2- Define an event based on that delegate
        //3 - Raise an event

        //1- Define a delegate
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        //2- Define an event based on the delegate
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video is being processed..");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        //3- Raise an event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this,EventArgs.Empty);
            }
        }
    }
}