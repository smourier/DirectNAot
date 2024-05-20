namespace DirectN.Extensions;

public static class IWICBitmapSourceExtensions
{
    public static D2D_SIZE_F GetDpiF(this IComObject<IWICBitmapSource> bitmap) => GetDpiF(bitmap?.Object!);
    public static D2D_SIZE_F GetDpiF(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetResolution(out var dx, out var dy);
        return new D2D_SIZE_F((float)dx, (float)dy);
    }

    public static D2D_SIZE_U GetSizeU(this IComObject<IWICBitmapSource> bitmap) => GetSizeU(bitmap?.Object!);
    public static D2D_SIZE_U GetSizeU(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetSize(out var width, out var height);
        return new D2D_SIZE_U(width, height);
    }

    public static D2D_SIZE_F GetSizeF(this IComObject<IWICBitmapSource> bitmap) => GetSizeF(bitmap?.Object!);
    public static D2D_SIZE_F GetSizeF(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetSize(out var width, out var height);
        return new D2D_SIZE_F(width, height);
    }

    public static D2D_SIZE_F GetDpi(this IComObject<IWICBitmapSource> bitmap) => GetDpi(bitmap?.Object!);
    public static D2D_SIZE_F GetDpi(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetResolution(out var dx, out var dy);
        return new D2D_SIZE_F((float)dx, (float)dy);
    }

    public static D2D_SIZE_U GetIntSize(this IComObject<IWICBitmapSource> bitmap) => GetIntSize(bitmap?.Object!);
    public static D2D_SIZE_U GetIntSize(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetSize(out var width, out var height);
        return new D2D_SIZE_U(width, height);
    }

    public static D2D_SIZE_U GetSize(this IComObject<IWICBitmapSource> bitmap) => GetSize(bitmap?.Object!);
    public static D2D_SIZE_U GetSize(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetSize(out var width, out var height);
        return new D2D_SIZE_U(width, height);
    }

    public static Guid GetPixelFormat(this IComObject<IWICBitmapSource> bitmap) => GetPixelFormat(bitmap?.Object!);
    public static Guid GetPixelFormat(this IWICBitmapSource bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        bitmap.GetPixelFormat(out var format);
        return format;
    }
}
