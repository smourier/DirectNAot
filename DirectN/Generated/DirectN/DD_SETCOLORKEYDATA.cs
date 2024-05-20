#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setcolorkeydata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SETCOLORKEYDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    public HRESULT ddRVal;
    public nint SetColorKey;
}
