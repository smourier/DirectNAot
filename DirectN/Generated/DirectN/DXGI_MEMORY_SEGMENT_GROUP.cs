#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/ne-dxgi1_4-dxgi_memory_segment_group
public enum DXGI_MEMORY_SEGMENT_GROUP
{
    DXGI_MEMORY_SEGMENT_GROUP_LOCAL = 0,
    DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL = 1,
}
