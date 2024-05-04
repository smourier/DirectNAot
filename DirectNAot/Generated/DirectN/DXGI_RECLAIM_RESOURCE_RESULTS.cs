#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/ne-dxgi1_5-dxgi_reclaim_resource_results
public enum DXGI_RECLAIM_RESOURCE_RESULTS
{
    DXGI_RECLAIM_RESOURCE_RESULT_OK = 0,
    DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED = 1,
    DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED = 2,
}
