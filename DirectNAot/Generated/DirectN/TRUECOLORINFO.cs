#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-truecolorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct TRUECOLORINFO
{
    public InlineArrayUInt32_3 dwBitMasks;
    public InlineArrayRGBQUAD_256 bmiColors;
}
