using DirectNAot.Extensions.Com;

namespace DirectNAot.Extensions;

public static class IWICBitmapEncoderExtensions
{
    public static WicBitmapFrameEncode CreateNewFrame(this IComObject<IWICBitmapEncoder> encoder) => CreateNewFrame(encoder?.Object!);
    public static WicBitmapFrameEncode CreateNewFrame(this IWICBitmapEncoder encoder)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        IPropertyBag2? bag = null;
        encoder.CreateNewFrame(out var frame, ref bag!).ThrowOnError();
        return new WicBitmapFrameEncode(new ComObject<IWICBitmapFrameEncode>(frame), new ComObject<IPropertyBag2>(bag));
    }

    public static void Initialize(this IComObject<IWICBitmapEncoder> encoder, IStream stream, WICBitmapEncoderCacheOption options = WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache) => Initialize(encoder?.Object!, stream, options);
    public static void Initialize(this IWICBitmapEncoder encoder, IStream stream, WICBitmapEncoderCacheOption options = WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        ArgumentNullException.ThrowIfNull(stream);
        encoder.Initialize(stream, options).ThrowOnError();
    }

    public static void Commit(this IComObject<IWICBitmapEncoder> encoder) => Commit(encoder?.Object!);
    public static void Commit(this IWICBitmapEncoder encoder)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.Commit().ThrowOnError();
    }

    public static void SetColorContexts(this IComObject<IWICBitmapEncoder> encoder, IEnumerable<IWICColorContext> contexts) => SetColorContexts(encoder?.Object!, contexts);
    public static void SetColorContexts(this IWICBitmapEncoder encoder, IEnumerable<IWICColorContext> contexts)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.SetColorContexts((uint)(contexts?.Count()).GetValueOrDefault(), contexts?.ToArray()!).ThrowOnError();
    }

    public static void SetPalette(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICPalette> palette) => SetPalette(encoder?.Object!, palette?.Object!);
    public static void SetPalette(this IWICBitmapEncoder encoder, IWICPalette palette)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.SetPalette(palette).ThrowOnError();
    }

    public static void SetPreview(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICBitmapSource> preview) => SetPreview(encoder?.Object!, preview?.Object!);
    public static void SetPreview(this IWICBitmapEncoder encoder, IWICBitmapSource preview)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.SetPreview(preview).ThrowOnError();
    }

    public static void SetThumbnail(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(encoder?.Object!, thumbnail?.Object!);
    public static void SetThumbnail(this IWICBitmapEncoder encoder, IWICBitmapSource thumbnail)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.SetThumbnail(thumbnail).ThrowOnError();
    }

    public static Guid GetContainerFormat(this IComObject<IWICBitmapEncoder> encoder) => GetContainerFormat(encoder?.Object!);
    public static Guid GetContainerFormat(this IWICBitmapEncoder encoder)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.GetContainerFormat(out var guid).ThrowOnError();
        return guid;
    }

    public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IComObject<IWICBitmapEncoder> encoder) => GetMetadataQueryWriter(encoder?.Object!);
    public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IWICBitmapEncoder encoder)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.GetMetadataQueryWriter(out var writer).ThrowOnError();
        return new ComObject<IWICMetadataQueryWriter>(writer);
    }

    public static IComObject<IWICBitmapEncoderInfo> GetEncoderInfo(this IComObject<IWICBitmapEncoder> encoder) => GetEncoderInfo(encoder?.Object!);
    public static IComObject<IWICBitmapEncoderInfo> GetEncoderInfo(this IWICBitmapEncoder encoder)
    {
        ArgumentNullException.ThrowIfNull(encoder);
        encoder.GetEncoderInfo(out var info).ThrowOnError();
        return new ComObject<IWICBitmapEncoderInfo>(info);
    }
}
