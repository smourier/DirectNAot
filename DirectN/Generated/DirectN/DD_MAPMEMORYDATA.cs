#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_mapmemorydata
public partial struct DD_MAPMEMORYDATA
{
    public nint lpDD;
    public BOOL bMap;
    public HANDLE hProcess;
    public nuint fpProcess;
    public HRESULT ddRVal;
}
