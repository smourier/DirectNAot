#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_INFO_QUEUE_FILTER_DESC
{
    public uint NumCategories;
    public nint pCategoryList;
    public uint NumSeverities;
    public nint pSeverityList;
    public uint NumIDs;
    public nint pIDList;
}
