#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_filter_range_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_FILTER_RANGE_DATA
{
    public int Minimum;
    public int Maximum;
    public int Default;
    public float Multiplier;
}
