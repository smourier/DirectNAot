namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicrawtonecurvepoint
[StructLayout(LayoutKind.Sequential)]
public partial struct WICRawToneCurvePoint
{
    public double Input;
    public double Output;
}
