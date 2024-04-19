namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvd_yuv
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVD_YUV
{
    public byte Reserved;
    public byte Y;
    public byte U;
    public byte V;
}
