#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ne-d2d1_3-d2d1_patch_edge_mode
public enum D2D1_PATCH_EDGE_MODE
{
    D2D1_PATCH_EDGE_MODE_ALIASED = 0,
    D2D1_PATCH_EDGE_MODE_ANTIALIASED = 1,
    D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED = 2,
}
