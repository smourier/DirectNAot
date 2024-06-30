#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createvportdata
public partial struct DD_CREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    public nint lpVideoPort;
    public HRESULT ddRVal;
    public nint CreateVideoPort;
}
