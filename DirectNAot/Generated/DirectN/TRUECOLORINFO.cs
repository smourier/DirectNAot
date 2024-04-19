namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-truecolorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct TRUECOLORINFO
{
    public InlineArrayUInt323 dwBitMasks;
    public InlineArrayRGBQUAD256 bmiColors;
}
