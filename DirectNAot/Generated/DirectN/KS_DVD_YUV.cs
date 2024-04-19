namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVD_YUV
{
    public byte Reserved;
    public byte Y;
    public byte V;
    public byte U;
}
