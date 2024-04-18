namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/ne-dxgi1_3-dxgi_frame_presentation_mode
public enum DXGI_FRAME_PRESENTATION_MODE
{
    DXGI_FRAME_PRESENTATION_MODE_COMPOSED = 0,
    DXGI_FRAME_PRESENTATION_MODE_OVERLAY = 1,
    DXGI_FRAME_PRESENTATION_MODE_NONE = 2,
    DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE = 3,
}
