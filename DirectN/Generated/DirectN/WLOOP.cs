#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WLOOP
{
    public uint cbSize;
    public uint ulType;
    public uint ulStart;
    public uint ulLength;
}
