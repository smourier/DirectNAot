#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/ns-dxgidebug-dxgi_info_queue_filter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_INFO_QUEUE_FILTER_DESC
{
    public uint NumCategories;
    public nint pCategoryList;
    public uint NumSeverities;
    public nint pSeverityList;
    public uint NumIDs;
    public nint pIDList;
}
