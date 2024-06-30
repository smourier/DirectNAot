#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/ns-mfreadwrite-mf_sink_writer_statistics
public partial struct MF_SINK_WRITER_STATISTICS
{
    public uint cb;
    public long llLastTimestampReceived;
    public long llLastTimestampEncoded;
    public long llLastTimestampProcessed;
    public long llLastStreamTickReceived;
    public long llLastSinkSampleRequest;
    public ulong qwNumSamplesReceived;
    public ulong qwNumSamplesEncoded;
    public ulong qwNumSamplesProcessed;
    public ulong qwNumStreamTicksReceived;
    public uint dwByteCountQueued;
    public ulong qwByteCountProcessed;
    public uint dwNumOutstandingSinkSampleRequests;
    public uint dwAverageSampleRateReceived;
    public uint dwAverageSampleRateEncoded;
    public uint dwAverageSampleRateProcessed;
}
