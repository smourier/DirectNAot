#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_d3dbufcallbacks
public partial struct DD_D3DBUFCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint CanCreateD3DBuffer;
    public nint CreateD3DBuffer;
    public nint DestroyD3DBuffer;
    public nint LockD3DBuffer;
    public nint UnlockD3DBuffer;
}
