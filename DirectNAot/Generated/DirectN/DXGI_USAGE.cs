namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-usage
public enum DXGI_USAGE
{
    DXGI_USAGE_SHADER_INPUT = 16,
    DXGI_USAGE_RENDER_TARGET_OUTPUT = 32,
    DXGI_USAGE_BACK_BUFFER = 64,
    DXGI_USAGE_SHARED = 128,
    DXGI_USAGE_READ_ONLY = 256,
    DXGI_USAGE_DISCARD_ON_PRESENT = 512,
    DXGI_USAGE_UNORDERED_ACCESS = 1024,
}
