namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DINSTRUCTION
{
    public byte bOpcode;
    public byte bSize;
    public ushort wCount;
}
