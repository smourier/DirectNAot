#nullable enable
namespace DirectN;

[Flags]
public enum DXGI_MWA_FLAGS : uint
{
    DXGI_MWA_NO_WINDOW_CHANGES = 1,
    DXGI_MWA_NO_ALT_ENTER = 2,
    DXGI_MWA_NO_PRINT_SCREEN = 4,
    DXGI_MWA_VALID = 7,
}
