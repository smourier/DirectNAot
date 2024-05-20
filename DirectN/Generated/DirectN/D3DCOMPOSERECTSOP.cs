#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dcomposerectsop
public enum D3DCOMPOSERECTSOP
{
    D3DCOMPOSERECTS_COPY = 1,
    D3DCOMPOSERECTS_OR = 2,
    D3DCOMPOSERECTS_AND = 3,
    D3DCOMPOSERECTS_NEG = 4,
}
