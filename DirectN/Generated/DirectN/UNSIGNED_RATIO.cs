#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-unsigned_ratio
[StructLayout(LayoutKind.Sequential)]
public partial struct UNSIGNED_RATIO
{
    public uint uiNumerator;
    public uint uiDenominator;
}
