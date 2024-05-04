#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getmocompguidsdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETMOCOMPGUIDSDATA
{
    public nint lpDD;
    public uint dwNumGuids;
    public nint lpGuids;
    public HRESULT ddRVal;
}
