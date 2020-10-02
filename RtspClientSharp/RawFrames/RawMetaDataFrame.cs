using System;

namespace RtspClientSharp.RawFrames
{
    public class RawMetaDataFrame : RawFrame
    {
        public override FrameType Type => FrameType.MetaData;

        public RawMetaDataFrame(DateTime timestamp, ArraySegment<byte> frameSegment) : base(timestamp, frameSegment)
        {
        }
    }
}