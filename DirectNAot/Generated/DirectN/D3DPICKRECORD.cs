#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DPICKRECORD
{
    public byte bOpcode;
    public byte bPad;
    public uint dwOffset;
    public float dvZ;
}
