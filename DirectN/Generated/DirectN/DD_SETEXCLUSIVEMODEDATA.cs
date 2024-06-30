#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setexclusivemodedata
public partial struct DD_SETEXCLUSIVEMODEDATA
{
    public nint lpDD;
    public uint dwEnterExcl;
    public uint dwReserved;
    public HRESULT ddRVal;
    public nint SetExclusiveMode;
}
