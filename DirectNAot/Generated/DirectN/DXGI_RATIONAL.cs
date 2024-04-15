namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgicommon/ns-dxgicommon-dxgi_rational
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_RATIONAL
{
    public uint Numerator;
    public uint Denominator;
}
