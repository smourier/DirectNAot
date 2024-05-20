namespace DirectN.Extensions;

public static class IWICBitmapExtensions
{
    public static IComObject<IWICBitmapLock> Lock(this IComObject<IWICBitmap> bitmap, WICBitmapLockFlags flags, WICRect? rect = null) => Lock(bitmap?.Object!, flags, rect);
    public static IComObject<IWICBitmapLock> Lock(this IWICBitmap bitmap, WICBitmapLockFlags flags, WICRect? rect = null)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        IWICBitmapLock value;
        if (rect.HasValue)
        {
            bitmap.Lock(rect.Value, (uint)flags, out value).ThrowOnError();
        }
        else
        {
            bitmap.Lock(Unsafe.NullRef<WICRect>(), (uint)flags, out value).ThrowOnError();
        }
        return new ComObject<IWICBitmapLock>(value);
    }
}
