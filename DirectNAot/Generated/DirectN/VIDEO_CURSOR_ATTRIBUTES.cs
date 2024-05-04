#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_CURSOR_ATTRIBUTES
{
    public ushort Width;
    public ushort Height;
    public short Column;
    public short Row;
    public byte Rate;
    public byte Enable;
}
