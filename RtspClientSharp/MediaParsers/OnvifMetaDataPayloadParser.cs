using System;
using RtspClientSharp.RawFrames;

namespace RtspClientSharp.MediaParsers
{
    public class OnvifMetaDataPayloadParser : IMediaPayloadParser
    {
        public Action<RawFrame> FrameGenerated { get; set; }

        public void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            var datA = System.Text.Encoding.UTF8.GetString(byteSegment.Array);
            System.Console.WriteLine("parse -------------");
            System.Console.WriteLine("DATA: " + datA + "\n++++++++++++++++++++++");

            var frame = new RawMetaDataFrame(DateTime.UtcNow, byteSegment);
            FrameGenerated?.Invoke(frame);
        }

        public void ResetState()
        {
            System.Console.WriteLine("reset -------------");
        }
    }
}