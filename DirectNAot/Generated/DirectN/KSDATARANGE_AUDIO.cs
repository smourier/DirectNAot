#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDATARANGE_AUDIO
{
    public KSDATAFORMAT DataRange;
    public uint MaximumChannels;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
}
