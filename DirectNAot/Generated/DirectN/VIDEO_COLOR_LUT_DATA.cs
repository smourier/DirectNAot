#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_COLOR_LUT_DATA
{
    public uint Length;
    public uint LutDataFormat;
    public InlineArrayByte1 LutData; // variable-length array placeholder
}
