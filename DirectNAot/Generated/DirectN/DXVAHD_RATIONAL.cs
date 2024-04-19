namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_rational
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_RATIONAL
{
    public uint Numerator;
    public uint Denominator;
}
