#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-paramdesc
public partial struct PARAMDESC
{
    public nint pparamdescex;
    public PARAMFLAGS wParamFlags;
}
