#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/olectl/ns-olectl-ocpfiparams
public partial struct OCPFIPARAMS
{
    public uint cbStructSize;
    public HWND hWndOwner;
    public int x;
    public int y;
    public PWSTR lpszCaption;
    public uint cObjects;
    public nint lplpUnk;
    public uint cPages;
    public nint lpPages;
    public uint lcid;
    public int dispidInitialProperty;
}
