namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVD_YCrCb
{
    public byte Reserved;
    public byte Y;
    public byte Cr;
    public byte Cb;
}
