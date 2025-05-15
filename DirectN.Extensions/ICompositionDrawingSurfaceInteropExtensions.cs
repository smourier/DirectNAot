namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class ICompositionDrawingSurfaceInteropExtensions
{
    public static IComObject<ID2D1DeviceContext> BeginDraw(this IComObject<ICompositionDrawingSurfaceInterop> surface, RECT? rect = null) => BeginDraw<ID2D1DeviceContext>(surface?.Object!, rect);
    public static IComObject<ID2D1DeviceContext> BeginDraw(this ICompositionDrawingSurfaceInterop surface, RECT? rect = null) => BeginDraw<ID2D1DeviceContext>(surface, rect);
    public static IComObject<T> BeginDraw<T>(this IComObject<ICompositionDrawingSurfaceInterop> surface, RECT? rect = null) where T : ID2D1DeviceContext => BeginDraw<T>(surface?.Object!, rect);
    public static IComObject<T> BeginDraw<T>(this ICompositionDrawingSurfaceInterop surface, RECT? rect = null) where T : ID2D1DeviceContext
    {
        ArgumentNullException.ThrowIfNull(surface);
        surface.BeginDraw(rect.CopyToPointer(), typeof(T).GUID, out var unk, out var offset).ThrowOnError();
        var dc = ComObject.FromPointer<T>(unk)!;
        if (!offset.IsZero)
        {
            var tx = D2D_MATRIX_3X2_F.Translation(offset.x, offset.y);
            dc.Object.SetTransform(tx);
        }
        return dc;
    }

    public static void EndDraw(this IComObject<ICompositionDrawingSurfaceInterop> surface) => EndDraw(surface?.Object!);
    public static void EndDraw(this ICompositionDrawingSurfaceInterop surface)
    {
        ArgumentNullException.ThrowIfNull(surface);
        surface.EndDraw().ThrowOnError();
    }
}
