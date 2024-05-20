#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9alphabitmapflags
public enum VMR9AlphaBitmapFlags
{
    VMR9AlphaBitmap_Disable = 1,
    VMR9AlphaBitmap_hDC = 2,
    VMR9AlphaBitmap_EntireDDS = 4,
    VMR9AlphaBitmap_SrcColorKey = 8,
    VMR9AlphaBitmap_SrcRect = 16,
    VMR9AlphaBitmap_FilterMode = 32,
}
