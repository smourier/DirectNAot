#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-present
[Flags]
public enum DXGI_PRESENT : uint
{
    DXGI_PRESENT_TEST = 1,
    DXGI_PRESENT_DO_NOT_SEQUENCE = 2,
    DXGI_PRESENT_RESTART = 4,
    DXGI_PRESENT_DO_NOT_WAIT = 8,
    DXGI_PRESENT_STEREO_PREFER_RIGHT = 16,
    DXGI_PRESENT_STEREO_TEMPORARY_MONO = 32,
    DXGI_PRESENT_RESTRICT_TO_OUTPUT = 64,
    DXGI_PRESENT_USE_DURATION = 256,
    DXGI_PRESENT_ALLOW_TEARING = 512,
}
