#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOENGINE_BUFFER_SIZE_RANGE
{
    public uint MinBufferBytes;
    public uint MaxBufferBytes;
}
