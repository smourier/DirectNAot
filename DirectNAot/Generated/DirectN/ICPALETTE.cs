namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ICPALETTE
{
    public uint dwFlags;
    public int iStart;
    public int iLen;
    public nint lppe;
}
