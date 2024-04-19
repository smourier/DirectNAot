namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9surfaceallocationflags
public enum VMR9SurfaceAllocationFlags
{
    VMR9AllocFlag_3DRenderTarget = 1,
    VMR9AllocFlag_DXVATarget = 2,
    VMR9AllocFlag_TextureSurface = 4,
    VMR9AllocFlag_OffscreenSurface = 8,
    VMR9AllocFlag_RGBDynamicSwitch = 16,
    VMR9AllocFlag_UsageReserved = 224,
    VMR9AllocFlag_UsageMask = 255,
}
