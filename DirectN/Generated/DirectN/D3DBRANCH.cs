#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DBRANCH
{
    public uint dwMask;
    public uint dwValue;
    public BOOL bNegate;
    public uint dwOffset;
}
