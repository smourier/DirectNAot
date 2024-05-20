#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-enum-modes
[Flags]
public enum DXGI_ENUM_MODES : uint
{
    DXGI_ENUM_MODES_INTERLACED = 1,
    DXGI_ENUM_MODES_SCALING = 2,
    DXGI_ENUM_MODES_STEREO = 4,
    DXGI_ENUM_MODES_DISABLED_STEREO = 8,
}
