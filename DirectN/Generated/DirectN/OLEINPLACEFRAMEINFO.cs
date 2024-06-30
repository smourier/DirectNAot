#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ns-oleidl-oleinplaceframeinfo
public partial struct OLEINPLACEFRAMEINFO
{
    public uint cb;
    public BOOL fMDIApp;
    public HWND hwndFrame;
    public HACCEL haccel;
    public uint cAccelEntries;
}
