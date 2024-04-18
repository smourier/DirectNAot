namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicrawtonecurve
[StructLayout(LayoutKind.Sequential)]
public partial struct WICRawToneCurve
{
    public uint cPoints;
    public InlineArrayWICRawToneCurvePoint1 aPoints; // variable-length array placeholder
}
