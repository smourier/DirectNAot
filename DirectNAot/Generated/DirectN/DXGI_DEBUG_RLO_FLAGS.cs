#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/ne-dxgidebug-dxgi_debug_rlo_flags
[Flags]
public enum DXGI_DEBUG_RLO_FLAGS
{
    DXGI_DEBUG_RLO_SUMMARY = 1,
    DXGI_DEBUG_RLO_DETAIL = 2,
    DXGI_DEBUG_RLO_IGNORE_INTERNAL = 4,
    DXGI_DEBUG_RLO_ALL = 7,
}
