#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_blurbehind
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_BLURBEHIND
{
    public uint dwFlags;
    public BOOL fEnable;
    public HRGN hRgnBlur;
    public BOOL fTransitionOnMaximized;
}
