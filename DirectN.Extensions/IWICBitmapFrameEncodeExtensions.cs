namespace DirectN.Extensions;

public static class IWICBitmapFrameEncodeExtensions
{
    public static void Initialize(this WicBitmapFrameEncode frameBag) => Initialize(frameBag.Encode!, frameBag?.Bag!);
    public static void Initialize(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IPropertyBag2>? bag = null) => Initialize(frame?.Object!, bag?.Object!);
    public static void Initialize(this IWICBitmapFrameEncode frame, IPropertyBag2? bag = null)
    {
        ArgumentNullException.ThrowIfNull(frame);
        if (bag != null)
        {
            frame.Initialize(bag).ThrowOnError();
        }
    }

    public static void SetPixelFormat(this WicBitmapFrameEncode frameBag, Guid pixelFormat) => SetPixelFormat(frameBag?.Encode!, pixelFormat);
    public static void SetPixelFormat(this IComObject<IWICBitmapFrameEncode> frame, Guid pixelFormat) => SetPixelFormat(frame?.Object!, pixelFormat);
    public static void SetPixelFormat(this IWICBitmapFrameEncode frame, Guid pixelFormat)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetPixelFormat(ref pixelFormat).ThrowOnError();
    }

    public static void SetSize(this WicBitmapFrameEncode frameBag, uint width, uint height) => SetSize(frameBag?.Encode!, width, height);
    public static void SetSize(this IComObject<IWICBitmapFrameEncode> frame, uint width, uint height) => SetSize(frame?.Object!, width, height);
    public static void SetSize(this IWICBitmapFrameEncode frame, uint width, uint height)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetSize(width, height).ThrowOnError();
    }

    public static void SetResolution(this WicBitmapFrameEncode frameBag, double dpiX, double dpiY) => SetResolution(frameBag?.Encode!, dpiX, dpiY);
    public static void SetResolution(this IComObject<IWICBitmapFrameEncode> frame, double dpiX, double dpiY) => SetResolution(frame?.Object!, dpiX, dpiY);
    public static void SetResolution(this IWICBitmapFrameEncode frame, double dpiX, double dpiY)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetResolution(dpiX, dpiY).ThrowOnError();
    }

    public static void WriteSource(this WicBitmapFrameEncode frameBag, IComObject<IWICBitmapSource> source, WICRect? sourceRectangle = null) => WriteSource(frameBag?.Encode!, source, sourceRectangle);
    public static void WriteSource(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICBitmapSource> source, WICRect? sourceRectangle = null) => WriteSource(frame?.Object!, source?.Object!, sourceRectangle);
    public static void WriteSource(this IWICBitmapFrameEncode frame, IWICBitmapSource source, WICRect? sourceRectangle = null)
    {
        ArgumentNullException.ThrowIfNull(frame);
        ArgumentNullException.ThrowIfNull(source);
        if (sourceRectangle.HasValue)
        {
            frame.WriteSource(source, sourceRectangle.Value).ThrowOnError();
        }
        else
        {
            frame.WriteSource(source, Unsafe.NullRef<WICRect>()).ThrowOnError();
        }
    }

    public static void WritePixels(this WicBitmapFrameEncode frameBag, uint lineCount, uint stride, byte[] pixels) => WritePixels(frameBag?.Encode!, lineCount, stride, pixels);
    public static void WritePixels(this IComObject<IWICBitmapFrameEncode> frame, uint lineCount, uint stride, byte[] pixels) => WritePixels(frame?.Object!, lineCount, stride, pixels);
    public static void WritePixels(this IWICBitmapFrameEncode frame, uint lineCount, uint stride, byte[] pixels)
    {
        ArgumentNullException.ThrowIfNull(frame);
        ArgumentNullException.ThrowIfNull(pixels);
        unsafe
        {
            fixed (byte* ptr = pixels)
            {
                frame.WritePixels(lineCount, stride, (uint)pixels.Length, (nint)ptr).ThrowOnError();
            }
        }
    }

    public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this WicBitmapFrameEncode frameBag) => GetMetadataQueryWriter(frameBag?.Encode!);
    public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IComObject<IWICBitmapFrameEncode> frame) => GetMetadataQueryWriter(frame?.Object!);
    public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IWICBitmapFrameEncode frame)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.GetMetadataQueryWriter(out var writer).ThrowOnError();
        return new ComObject<IWICMetadataQueryWriter>(writer);
    }

    public static void Commit(this WicBitmapFrameEncode frameBag) => Commit(frameBag?.Encode!);
    public static void Commit(this IComObject<IWICBitmapFrameEncode> frame) => Commit(frame?.Object!);
    public static void Commit(this IWICBitmapFrameEncode frame)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.Commit().ThrowOnError();
    }

    public static void SetColorContexts(this WicBitmapFrameEncode frameBag, IEnumerable<IComObject<IWICColorContext>> contexts) => SetColorContexts(frameBag?.Encode!, contexts);
    public static void SetColorContexts(this WicBitmapFrameEncode frameBag, IEnumerable<IWICColorContext> contexts) => SetColorContexts(frameBag?.Encode!, contexts);
    public static void SetColorContexts(this IComObject<IWICBitmapFrameEncode> frame, IEnumerable<IComObject<IWICColorContext>> contexts) => SetColorContexts(frame?.Object!, contexts?.Select(c => c.Object)!);
    public static void SetColorContexts(this IComObject<IWICBitmapFrameEncode> frame, IEnumerable<IWICColorContext> contexts) => SetColorContexts(frame?.Object!, contexts);
    public static void SetColorContexts(this IWICBitmapFrameEncode frame, IEnumerable<IWICColorContext> contexts)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetColorContexts((uint)(contexts?.Count()).GetValueOrDefault(), contexts?.ToArray()!).ThrowOnError();
    }

    public static void SetPalette(this WicBitmapFrameEncode frameBag, IComObject<IWICPalette> palette) => SetPalette(frameBag?.Encode!, palette);
    public static void SetPalette(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICPalette> palette) => SetPalette(frame?.Object!, palette?.Object!);
    public static void SetPalette(this IWICBitmapFrameEncode frame, IWICPalette palette)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetPalette(palette).ThrowOnError();
    }

    public static void SetThumbnail(this WicBitmapFrameEncode frameBag, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(frameBag?.Encode!, thumbnail);
    public static void SetThumbnail(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(frame?.Object!, thumbnail?.Object!);
    public static void SetThumbnail(this IWICBitmapFrameEncode frame, IWICBitmapSource thumbnail)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.SetThumbnail(thumbnail).ThrowOnError();
    }
}
