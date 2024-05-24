#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_performance_data
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_PERFORMANCE_DATA
{
    public ulong AudioCyclesSinceLastQuery;
    public ulong TotalCyclesSinceLastQuery;
    public uint MinimumCyclesPerQuantum;
    public uint MaximumCyclesPerQuantum;
    public uint MemoryUsageInBytes;
    public uint CurrentLatencyInSamples;
    public uint GlitchesSinceEngineStarted;
    public uint ActiveSourceVoiceCount;
    public uint TotalSourceVoiceCount;
    public uint ActiveSubmixVoiceCount;
    public uint ActiveResamplerCount;
    public uint ActiveMatrixMixCount;
    public uint ActiveXmaSourceVoices;
    public uint ActiveXmaStreams;
}
