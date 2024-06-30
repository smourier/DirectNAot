#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createsurfaceexdata
public partial struct DD_CREATESURFACEEXDATA
{
    public uint dwFlags;
    public nint lpDDLcl;
    public nint lpDDSLcl;
    public HRESULT ddRVal;
}
