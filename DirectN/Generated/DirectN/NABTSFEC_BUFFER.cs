#nullable enable
namespace DirectN;

public partial struct NABTSFEC_BUFFER
{
    public uint dataSize;
    public ushort groupID;
    public ushort Reserved;
    public InlineArrayByte_448 data;
}
