#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_writer_statistics_ex
public partial struct WM_WRITER_STATISTICS_EX
{
    public uint dwBitratePlusOverhead;
    public uint dwCurrentSampleDropRateInQueue;
    public uint dwCurrentSampleDropRateInCodec;
    public uint dwCurrentSampleDropRateInMultiplexer;
    public uint dwTotalSampleDropsInQueue;
    public uint dwTotalSampleDropsInCodec;
    public uint dwTotalSampleDropsInMultiplexer;
}
