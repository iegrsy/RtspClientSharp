using System;
using RtspClientSharp.RawFrames;

namespace RtspClientSharp.MediaParsers
{
    public class OnvifMetaDataPayloadParser : IMediaPayloadParser
    {
        public Action<RawFrame> FrameGenerated { get; set; }

        public void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            var frame = new RawMetaDataFrame(DateTime.UtcNow, byteSegment);
            FrameGenerated?.Invoke(frame);
        }

        public void ResetState()
        {
            System.Console.WriteLine("------------- OnvifMetaDataPayloadParser: RESET -------------");
        }
    }
}