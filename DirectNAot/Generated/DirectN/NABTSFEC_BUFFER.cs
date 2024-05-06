#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct NABTSFEC_BUFFER
{
    public uint dataSize;
    public ushort groupID;
    public ushort Reserved;
    public InlineArrayByte_448 data;
}
