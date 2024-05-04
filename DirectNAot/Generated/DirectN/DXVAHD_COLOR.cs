#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_color
[StructLayout(LayoutKind.Explicit)]
public partial struct DXVAHD_COLOR
{
    [FieldOffset(0)]
    public DXVAHD_COLOR_RGBA RGB;
    
    [FieldOffset(0)]
    public DXVAHD_COLOR_YCbCrA YCbCr;
}
