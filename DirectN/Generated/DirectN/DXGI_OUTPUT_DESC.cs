#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_output_desc
public partial struct DXGI_OUTPUT_DESC
{
    public InlineArraySystemChar_32 DeviceName;
    public RECT DesktopCoordinates;
    public BOOL AttachedToDesktop;
    public DXGI_MODE_ROTATION Rotation;
    public HMONITOR Monitor;
}
