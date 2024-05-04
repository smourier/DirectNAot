namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_output_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_OUTPUT_DESC
{
    public InlineArraySystemChar32 DeviceName;
    public RECT DesktopCoordinates;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AttachedToDesktop;
    public DXGI_MODE_ROTATION Rotation;
    public HMONITOR Monitor;
}
