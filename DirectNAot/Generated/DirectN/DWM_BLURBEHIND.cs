namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_blurbehind
[StructLayout(LayoutKind.Sequential)]
public partial struct DWM_BLURBEHIND
{
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fEnable;
    public HRGN hRgnBlur;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fTransitionOnMaximized;
}
