#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSWAVE_BUFFER
{
    public uint Attributes;
    public uint BufferSize;
    public nint BufferAddress;
}
