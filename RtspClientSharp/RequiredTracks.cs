using System;

namespace RtspClientSharp
{
    [Flags]
    public enum RequiredTracks
    {
        All = 0,
        Video = 1,
        Audio = 2,
        MetaData = 3,
        //All = Video | Audio | MetaData
    }
}