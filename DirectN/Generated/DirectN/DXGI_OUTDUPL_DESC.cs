#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_OUTDUPL_DESC
{
    public DXGI_MODE_DESC ModeDesc;
    public DXGI_MODE_ROTATION Rotation;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DesktopImageInSystemMemory;
}
