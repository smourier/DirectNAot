#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/ns-dxgi1_6-dxgi_output_desc1
public partial struct DXGI_OUTPUT_DESC1
{
    public InlineArraySystemChar_32 DeviceName;
    public RECT DesktopCoordinates;
    public BOOL AttachedToDesktop;
    public DXGI_MODE_ROTATION Rotation;
    public HMONITOR Monitor;
    public uint BitsPerColor;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public InlineArraySingle_2 RedPrimary;
    public InlineArraySingle_2 GreenPrimary;
    public InlineArraySingle_2 BluePrimary;
    public InlineArraySingle_2 WhitePoint;
    public float MinLuminance;
    public float MaxLuminance;
    public float MaxFullFrameLuminance;
}
