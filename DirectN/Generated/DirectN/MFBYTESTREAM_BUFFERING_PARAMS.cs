#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfbytestream_buffering_params
public partial struct MFBYTESTREAM_BUFFERING_PARAMS
{
    public ulong cbTotalFileSize;
    public ulong cbPlayableDataSize;
    public nint prgBuckets;
    public uint cBuckets;
    public ulong qwNetBufferingTime;
    public ulong qwExtraBufferingTimeDuringSeek;
    public ulong qwPlayDuration;
    public float dRate;
}
