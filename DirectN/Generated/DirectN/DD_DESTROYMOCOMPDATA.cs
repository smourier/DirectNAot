#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_destroymocompdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public HRESULT ddRVal;
}
