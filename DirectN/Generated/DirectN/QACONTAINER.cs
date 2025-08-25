#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-qacontainer
public partial struct QACONTAINER
{
    public uint cbSize;
    public nint pClientSite;
    public nint pAdviseSink;
    public nint pPropertyNotifySink;
    public nint pUnkEventSink;
    public uint dwAmbientFlags;
    public uint colorFore;
    public uint colorBack;
    public nint pFont;
    public nint pUndoMgr;
    public uint dwAppearance;
    public int lcid;
    public HPALETTE hpal;
    public nint pBindHost;
    public nint pOleControlSite;
    public nint pServiceProvider;
}
