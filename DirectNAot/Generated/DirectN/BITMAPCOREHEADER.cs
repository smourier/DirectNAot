namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapcoreheader
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPCOREHEADER
{
    public uint bcSize;
    public ushort bcWidth;
    public ushort bcHeight;
    public ushort bcPlanes;
    public ushort bcBitCount;
}
