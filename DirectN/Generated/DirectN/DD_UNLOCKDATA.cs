#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_unlockdata
public partial struct DD_UNLOCKDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public HRESULT ddRVal;
    public nint Unlock;
}
