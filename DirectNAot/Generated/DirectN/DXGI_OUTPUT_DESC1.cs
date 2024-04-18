namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/ns-dxgi1_6-dxgi_output_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_OUTPUT_DESC1
{
    public InlineArraySystemChar32 DeviceName;
    public FoundationRECT DesktopCoordinates;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AttachedToDesktop;
    public DXGI_MODE_ROTATION Rotation;
    public HMONITOR Monitor;
    public uint BitsPerColor;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public InlineArraySingle2 RedPrimary;
    public InlineArraySingle2 GreenPrimary;
    public InlineArraySingle2 BluePrimary;
    public InlineArraySingle2 WhitePoint;
    public float MinLuminance;
    public float MaxLuminance;
    public float MaxFullFrameLuminance;
}
