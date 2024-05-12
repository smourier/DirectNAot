using DirectNAot.Extensions.Com;

namespace DirectNAot.Extensions;

public static class IWICBitmapDecoderExtensions
{
    public static Guid GetContainerFormat(this IComObject<IWICBitmapDecoder> decoder) => GetContainerFormat(decoder?.Object!);
    public static Guid GetContainerFormat(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetContainerFormat(out var value).ThrowOnError();
        return value;
    }

    public static uint GetFrameCount(this IComObject<IWICBitmapDecoder> decoder) => GetFrameCount(decoder?.Object!);
    public static uint GetFrameCount(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetFrameCount(out var value).ThrowOnError();
        return value;
    }

    public static IComObject<IWICBitmapFrameDecode> GetFrame(this IComObject<IWICBitmapDecoder> decoder, int index) => GetFrame(decoder?.Object!, index);
    public static IComObject<IWICBitmapFrameDecode> GetFrame(this IWICBitmapDecoder decoder, int index)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetFrame((uint)index, out var value).ThrowOnError();
        return new ComObject<IWICBitmapFrameDecode>(value);
    }

    public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IComObject<IWICBitmapDecoder> decoder) => GetMetadataQueryReader(decoder?.Object!);
    public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetMetadataQueryReader(out var value).ThrowOnError();
        return new ComObject<IWICMetadataQueryReader>(value);
    }

    public static IComObject<IWICBitmapDecoderInfo> GetDecoderInfo(this IComObject<IWICBitmapDecoder> decoder) => GetDecoderInfo(decoder?.Object!);
    public static IComObject<IWICBitmapDecoderInfo> GetDecoderInfo(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetDecoderInfo(out var value).ThrowOnError();
        return new ComObject<IWICBitmapDecoderInfo>(value);
    }

    public static IComObject<IWICBitmapSource>? GetThumbnail(this IComObject<IWICBitmapDecoder> decoder) => GetThumbnail(decoder?.Object!);
    public static IComObject<IWICBitmapSource>? GetThumbnail(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetThumbnail(out var value).ThrowOnError(false);
        if (value == null)
            return null;

        return new ComObject<IWICBitmapSource>(value);
    }

    public static IComObject<IWICBitmapSource>? GetPreview(this IComObject<IWICBitmapDecoder> decoder) => GetPreview(decoder?.Object!);
    public static IComObject<IWICBitmapSource>? GetPreview(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetPreview(out var value).ThrowOnError(false);
        if (value == null)
            return null;

        return new ComObject<IWICBitmapSource>(value);
    }

    public static WICBitmapDecoderCapabilities QueryCapability(this IComObject<IWICBitmapDecoder> decoder, IStream stream) => QueryCapability(decoder?.Object!, stream);
    public static WICBitmapDecoderCapabilities QueryCapability(this IWICBitmapDecoder decoder, IStream stream)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        ArgumentNullException.ThrowIfNull(stream);
        decoder.QueryCapability(stream, out var capabilities).ThrowOnError(false);
        return (WICBitmapDecoderCapabilities)capabilities;
    }

    public static void CopyPalette(this IComObject<IWICBitmapDecoder> decoder, IWICPalette palette) => CopyPalette(decoder?.Object!, palette);
    public static void CopyPalette(this IWICBitmapDecoder decoder, IWICPalette palette)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.CopyPalette(palette).ThrowOnError(false);
    }

    public static void Initialize(this IComObject<IWICBitmapDecoder> decoder, IStream stream, WICDecodeOptions options) => Initialize(decoder?.Object!, stream, options);
    public static void Initialize(this IWICBitmapDecoder decoder, IStream stream, WICDecodeOptions options)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        ArgumentNullException.ThrowIfNull(stream);
        decoder.Initialize(stream, options).ThrowOnError(false);
    }

    public static IComObject<IWICColorContext>[] GetColorContexts(this IComObject<IWICBitmapDecoder> decoder) => GetColorContexts(decoder?.Object!);
    public static IComObject<IWICColorContext>[] GetColorContexts(this IWICBitmapDecoder decoder)
    {
        ArgumentNullException.ThrowIfNull(decoder);
        decoder.GetColorContexts(0, null!, out var count);
        if (count == 0)
            return [];

        var colorContexts = WicImagingFactory.CreateColorContexts((int)count);
        var array = colorContexts.Select(cc => cc.Object).ToArray();
        decoder.GetColorContexts((uint)colorContexts.Length, array, out _).ThrowOnError();
        return colorContexts;
    }
}
