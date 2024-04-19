namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfargb
[StructLayout(LayoutKind.Sequential)]
public partial struct MFARGB
{
    public byte rgbBlue;
    public byte rgbGreen;
    public byte rgbRed;
    public byte rgbAlpha;
}
