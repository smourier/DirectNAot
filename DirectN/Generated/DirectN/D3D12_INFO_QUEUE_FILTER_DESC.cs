#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_info_queue_filter_desc
public partial struct D3D12_INFO_QUEUE_FILTER_DESC
{
    public uint NumCategories;
    public nint pCategoryList;
    public uint NumSeverities;
    public nint pSeverityList;
    public uint NumIDs;
    public nint pIDList;
}
