#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_frequency
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_Frequency
{
    public uint Numerator;
    public uint Denominator;
}
