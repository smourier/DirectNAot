#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCBCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
}
