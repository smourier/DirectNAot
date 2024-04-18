namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_hardware_composition_support_flags
public enum DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS
{
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN = 1,
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED = 2,
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED = 4,
}
