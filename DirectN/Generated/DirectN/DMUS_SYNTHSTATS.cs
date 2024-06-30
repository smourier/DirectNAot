#nullable enable
namespace DirectN;

public partial struct DMUS_SYNTHSTATS
{
    public uint dwSize;
    public uint dwValidStats;
    public uint dwVoices;
    public uint dwTotalCPU;
    public uint dwCPUPerVoice;
    public uint dwLostNotes;
    public uint dwFreeMemory;
    public int lPeakVolume;
}
