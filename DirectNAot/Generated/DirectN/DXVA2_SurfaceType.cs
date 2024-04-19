namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_surfacetype
public enum DXVA2_SurfaceType
{
    DXVA2_SurfaceType_DecoderRenderTarget = 0,
    DXVA2_SurfaceType_ProcessorRenderTarget = 1,
    DXVA2_SurfaceType_D3DRenderTargetTexture = 2,
}
