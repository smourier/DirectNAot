namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-audio_stream_config_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_STREAM_CONFIG_CAPS
{
    public Guid guid;
    public uint MinimumChannels;
    public uint MaximumChannels;
    public uint ChannelsGranularity;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint BitsPerSampleGranularity;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
    public uint SampleFrequencyGranularity;
}
