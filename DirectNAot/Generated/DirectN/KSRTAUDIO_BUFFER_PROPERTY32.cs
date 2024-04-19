namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER_PROPERTY32
{
    public KSIDENTIFIER Property;
    public uint BaseAddress;
    public uint RequestedBufferSize;
}
