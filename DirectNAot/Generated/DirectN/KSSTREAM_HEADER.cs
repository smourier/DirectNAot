#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSSTREAM_HEADER
{
    public uint Size;
    public uint TypeSpecificFlags;
    public KSTIME PresentationTime;
    public long Duration;
    public uint FrameExtent;
    public uint DataUsed;
    public nint Data;
    public uint OptionsFlags;
    public uint Reserved;
}
