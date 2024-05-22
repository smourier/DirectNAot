namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1BitmapExtensions
{
    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1ColorContext>? GetColorContext(this IComObject<ID2D1Bitmap1> bitmap) => GetColorContext(bitmap?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1ColorContext>? GetColorContext(this ID2D1Bitmap1 bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetColorContext(out var value);
        return value == null ? null : new ComObject<ID2D1ColorContext>(value);
    }

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_MAPPED_RECT Map(this IComObject<ID2D1Bitmap1> bitmap, D2D1_MAP_OPTIONS options = D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_NONE) => Map(bitmap?.Object!, options);

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_MAPPED_RECT Map(this ID2D1Bitmap1 bitmap, D2D1_MAP_OPTIONS options = D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_NONE)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.Map(options, out var rc).ThrowOnError();
        return rc;
    }

    [SupportedOSPlatform("windows8.0")]
    public static void Unmap(this IComObject<ID2D1Bitmap1> bitmap) => Unmap(bitmap?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static void Unmap(this ID2D1Bitmap1 bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.Unmap().ThrowOnError();
    }

    public static D2D_SIZE_F GetDpi(this IComObject<ID2D1Bitmap> bitmap) => GetDpi(bitmap?.Object!);
    public static D2D_SIZE_F GetDpi(this ID2D1Bitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetDpi(out var dx, out var dy);
        return new D2D_SIZE_F(dx, dy);
    }

    public static D2D_SIZE_F GetSize(this IComObject<ID2D1Bitmap> bitmap) => GetSize(bitmap?.Object!);
    public static D2D_SIZE_F GetSize(this ID2D1Bitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        return bitmap.GetSize();
    }

    public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1Bitmap> bitmap) => GetPixelSize(bitmap?.Object!);
    public static D2D_SIZE_U GetPixelSize(this ID2D1Bitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        return bitmap.GetPixelSize();
    }

    public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1Bitmap> bitmap) => GetPixelFormat(bitmap?.Object!);
    public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1Bitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        return bitmap.GetPixelFormat();
    }

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_BITMAP_OPTIONS GetOptions(this IComObject<ID2D1Bitmap1> bitmap) => GetOptions(bitmap?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_BITMAP_OPTIONS GetOptions(this ID2D1Bitmap1 bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        return bitmap.GetOptions();
    }

    public static void CopyFromBitmap(this IComObject<ID2D1Bitmap> bitmap, IComObject<ID2D1Bitmap> source, D2D_POINT_2U? destinationPoint = null, D2D_RECT_U? sourceRect = null) => CopyFromBitmap(bitmap?.Object!, source?.Object!, destinationPoint, sourceRect);
    public static void CopyFromBitmap(this ID2D1Bitmap bitmap, ID2D1Bitmap source, D2D_POINT_2U? destinationPoint = null, D2D_RECT_U? sourceRect = null)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        ArgumentNullException.ThrowIfNull(source);
        bitmap.CopyFromBitmap(destinationPoint.CopyToPointer(), source, sourceRect.CopyToPointer()).ThrowOnError();
    }

    public static void CopyFromRenderTarget(this IComObject<ID2D1Bitmap> bitmap, IComObject<ID2D1RenderTarget> renderTarget, D2D_POINT_2U? destinationPoint = null, D2D_RECT_U? sourceRect = null) => CopyFromRenderTarget(bitmap?.Object!, renderTarget?.Object!, destinationPoint, sourceRect);
    public static void CopyFromRenderTarget(this ID2D1Bitmap bitmap, ID2D1RenderTarget renderTarget, D2D_POINT_2U? destinationPoint = null, D2D_RECT_U? sourceRect = null)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        ArgumentNullException.ThrowIfNull(renderTarget);
        bitmap.CopyFromRenderTarget(destinationPoint.CopyToPointer(), renderTarget, sourceRect.CopyToPointer()).ThrowOnError();
    }

    public static void CopyFromMemory(this IComObject<ID2D1Bitmap> bitmap, nint sourceData, uint pitch, D2D_RECT_U? destinationRect = null) => CopyFromMemory(bitmap?.Object!, sourceData, pitch, destinationRect);
    public static void CopyFromMemory(this ID2D1Bitmap bitmap, nint sourceData, uint pitch, D2D_RECT_U? destinationRect = null)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        if (sourceData == 0)
            throw new ArgumentException(null, nameof(sourceData));

        if (pitch == 0)
            throw new ArgumentException(null, nameof(pitch));

        bitmap.CopyFromMemory(destinationRect.CopyToPointer(), sourceData, pitch).ThrowOnError();
    }
}
