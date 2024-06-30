#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_lockdata
public partial struct DD_LOCKDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint bHasRect;
    public RECTL rArea;
    public nint lpSurfData;
    public HRESULT ddRVal;
    public nint Lock;
    public uint dwFlags;
    public nuint fpProcess;
}
