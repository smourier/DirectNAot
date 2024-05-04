#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ImageItemData
{
    public uint Size;
    public uint Position;
    public nint Desc;
    public uint DescSize;
    public nint Data;
    public uint DataSize;
    public uint Cookie;
}
