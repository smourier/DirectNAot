#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DRVSETCOLORKEYDATA
{
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    public HRESULT ddRVal;
    public nint SetColorKey;
}
