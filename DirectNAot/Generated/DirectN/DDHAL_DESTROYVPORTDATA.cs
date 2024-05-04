#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public HRESULT ddRVal;
    public nint DestroyVideoPort;
}
