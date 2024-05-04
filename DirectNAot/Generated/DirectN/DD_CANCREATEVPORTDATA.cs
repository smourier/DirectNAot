#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_cancreatevportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CANCREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    public HRESULT ddRVal;
    public nint CanCreateVideoPort;
}
