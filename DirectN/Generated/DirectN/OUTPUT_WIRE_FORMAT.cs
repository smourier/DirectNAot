#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OUTPUT_WIRE_FORMAT
{
    public OUTPUT_COLOR_ENCODING ColorEncoding;
    public uint BitsPerPixel;
}
