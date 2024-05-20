#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER_PROPERTY
{
    public KSIDENTIFIER Property;
    public nint BaseAddress;
    public uint RequestedBufferSize;
}
