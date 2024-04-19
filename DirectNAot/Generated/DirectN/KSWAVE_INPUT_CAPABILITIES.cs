namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSWAVE_INPUT_CAPABILITIES
{
    public uint MaximumChannelsPerConnection;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
    public uint TotalConnections;
    public uint ActiveConnections;
}
