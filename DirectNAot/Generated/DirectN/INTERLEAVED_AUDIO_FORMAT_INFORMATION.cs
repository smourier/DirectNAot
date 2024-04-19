namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct INTERLEAVED_AUDIO_FORMAT_INFORMATION
{
    public uint Size;
    public uint PrimaryChannelCount;
    public uint PrimaryChannelStartPosition;
    public uint PrimaryChannelMask;
    public uint InterleavedChannelCount;
    public uint InterleavedChannelStartPosition;
    public uint InterleavedChannelMask;
}
