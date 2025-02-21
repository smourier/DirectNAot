#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-notifyicondataw
public partial struct NOTIFYICONDATAW
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint uTimeout;
        
        [FieldOffset(0)]
        public uint uVersion;
    }
    
    public uint cbSize;
    public HWND hWnd;
    public uint uID;
    public NOTIFY_ICON_DATA_FLAGS uFlags;
    public uint uCallbackMessage;
    public HICON hIcon;
    public InlineArraySystemChar_128 szTip;
    public NOTIFY_ICON_STATE dwState;
    public NOTIFY_ICON_STATE dwStateMask;
    public InlineArraySystemChar_256 szInfo;
    public _Anonymous_e__Union Anonymous;
    public InlineArraySystemChar_64 szInfoTitle;
    public NOTIFY_ICON_INFOTIP_FLAGS dwInfoFlags;
    public Guid guidItem;
    public HICON hBalloonIcon;
}
