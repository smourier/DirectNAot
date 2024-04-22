namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fontdiff
[StructLayout(LayoutKind.Sequential)]
public partial struct FONTDIFF
{
    public byte jReserved1;
    public byte jReserved2;
    public byte jReserved3;
    public byte bWeight;
    public ushort usWinWeight;
    public ushort fsSelection;
    public short fwdAveCharWidth;
    public short fwdMaxCharInc;
    public POINTL ptlCaret;
}
