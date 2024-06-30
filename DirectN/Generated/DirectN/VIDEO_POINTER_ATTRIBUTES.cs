#nullable enable
namespace DirectN;

public partial struct VIDEO_POINTER_ATTRIBUTES
{
    public uint Flags;
    public uint Width;
    public uint Height;
    public uint WidthInBytes;
    public uint Enable;
    public short Column;
    public short Row;
    public InlineArrayByte_1 Pixels; // variable-length array placeholder
}
