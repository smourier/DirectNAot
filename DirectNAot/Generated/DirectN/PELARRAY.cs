namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PELARRAY
{
    public int paXCount;
    public int paYCount;
    public int paXExt;
    public int paYExt;
    public byte paRGBs;
}
