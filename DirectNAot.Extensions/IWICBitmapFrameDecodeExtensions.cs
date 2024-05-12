﻿using DirectNAot.Extensions.Com;

namespace DirectNAot.Extensions;

public static class IWICBitmapFrameDecodeExtensions
{
    public static IComObject<IWICMetadataQueryReader>? GetMetadataQueryReader(this IComObject<IWICBitmapFrameDecode> frame) => GetMetadataQueryReader(frame?.Object!);
    public static IComObject<IWICMetadataQueryReader>? GetMetadataQueryReader(this IWICBitmapFrameDecode frame)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.GetMetadataQueryReader(out var value).ThrowOnError(false);
        if (value == null)
            return null;

        return new ComObject<IWICMetadataQueryReader>(value);
    }

    public static IComObject<IWICBitmapSource>? GetThumbnail(this IComObject<IWICBitmapFrameDecode> frame) => GetThumbnail(frame?.Object!);
    public static IComObject<IWICBitmapSource>? GetThumbnail(this IWICBitmapFrameDecode frame)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.GetThumbnail(out var value).ThrowOnError(false);
        if (value == null)
            return null;

        return new ComObject<IWICBitmapSource>(value);
    }

    public static IComObject<IWICColorContext>[] GetColorContexts(this IComObject<IWICBitmapFrameDecode> frame) => GetColorContexts(frame?.Object!);
    public static IComObject<IWICColorContext>[] GetColorContexts(this IWICBitmapFrameDecode frame)
    {
        ArgumentNullException.ThrowIfNull(frame);
        frame.GetColorContexts(0, ref Unsafe.NullRef<IWICColorContext[]>(), out var count);
        if (count == 0)
            return [];

        var colorContexts = WicImagingFactory.CreateColorContexts((int)count);
        var array = colorContexts.Select(cc => cc.Object).ToArray();
        frame.GetColorContexts((uint)colorContexts.Length, ref array, out _).ThrowOnError();
        return colorContexts;
    }
}
