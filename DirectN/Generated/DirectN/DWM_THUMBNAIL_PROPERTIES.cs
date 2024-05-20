#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_thumbnail_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct DWM_THUMBNAIL_PROPERTIES
{
    public uint dwFlags;
    public RECT rcDestination;
    public RECT rcSource;
    public byte opacity;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fVisible;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSourceClientAreaOnly;
}
