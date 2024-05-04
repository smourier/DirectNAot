#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ne-dxgi-dxgi_swap_effect
public enum DXGI_SWAP_EFFECT
{
    DXGI_SWAP_EFFECT_DISCARD = 0,
    DXGI_SWAP_EFFECT_SEQUENTIAL = 1,
    DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL = 3,
    DXGI_SWAP_EFFECT_FLIP_DISCARD = 4,
}
