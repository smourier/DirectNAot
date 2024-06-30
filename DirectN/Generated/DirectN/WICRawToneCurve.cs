#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicrawtonecurve
public partial struct WICRawToneCurve
{
    public uint cPoints;
    public InlineArrayWICRawToneCurvePoint_1 aPoints; // variable-length array placeholder
}
