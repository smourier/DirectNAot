namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UNIDRVINFO
{
    public uint dwSize;
    public uint flGenFlags;
    public ushort wType;
    public ushort fCaps;
    public ushort wXRes;
    public ushort wYRes;
    public short sYAdjust;
    public short sYMoved;
    public ushort wPrivateData;
    public short sShift;
    public INVOC SelectFont;
    public INVOC UnSelectFont;
    public InlineArrayUInt164 wReserved;
}
