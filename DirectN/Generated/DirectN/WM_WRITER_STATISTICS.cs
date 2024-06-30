#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_writer_statistics
public partial struct WM_WRITER_STATISTICS
{
    public ulong qwSampleCount;
    public ulong qwByteCount;
    public ulong qwDroppedSampleCount;
    public ulong qwDroppedByteCount;
    public uint dwCurrentBitrate;
    public uint dwAverageBitrate;
    public uint dwExpectedBitrate;
    public uint dwCurrentSampleRate;
    public uint dwAverageSampleRate;
    public uint dwExpectedSampleRate;
}
