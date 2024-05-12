using DirectNAot.Extensions.Com;
using DirectNAot.Extensions.Utilities;

namespace DirectNAot.Extensions;

public static class IWICImagingFactoryExtensions
{
    public static IComObject<IWICPalette> CreatePalette(this IComObject<IWICImagingFactory> factory) => CreatePalette(factory?.Object!);
    public static IComObject<IWICPalette> CreatePalette(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreatePalette(out var value).ThrowOnError();
        return new ComObject<IWICPalette>(value);
    }

    public static IComObject<IWICBitmap> CreateBitmap(this IComObject<IWICImagingFactory> factory, uint width, uint height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => CreateBitmap(factory?.Object!, width, height, pixelFormat, option);
    public static IComObject<IWICBitmap> CreateBitmap(this IWICImagingFactory factory, uint width, uint height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmap(width, height, pixelFormat, option, out var value).ThrowOnError();
        return new ComObject<IWICBitmap>(value);
    }

    public static IComObject<IWICBitmapClipper> CreateBitmapClipper(this IComObject<IWICImagingFactory> factory) => CreateBitmapClipper(factory?.Object!);
    public static IComObject<IWICBitmapClipper> CreateBitmapClipper(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmapClipper(out var value).ThrowOnError();
        return new ComObject<IWICBitmapClipper>(value);
    }

    public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator(this IComObject<IWICImagingFactory> factory) => CreateBitmapFlipRotator(factory?.Object!);
    public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmapFlipRotator(out var value).ThrowOnError();
        return new ComObject<IWICBitmapFlipRotator>(value);
    }

    public static IComObject<IWICBitmapScaler> CreateBitmapScaler(this IComObject<IWICImagingFactory> factory) => CreateBitmapScaler(factory?.Object!);
    public static IComObject<IWICBitmapScaler> CreateBitmapScaler(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmapScaler(out var value).ThrowOnError();
        return new ComObject<IWICBitmapScaler>(value);
    }

    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(this IComObject<IWICImagingFactory> factory, string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromFilename(factory?.Object!, fileName, guidVendor, desiredAccess, metadataOptions);
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(this IWICImagingFactory factory, string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(fileName);

        var rights = (GENERIC_ACCESS_RIGHTS)0;
        if (desiredAccess.HasFlag(FileAccess.Read))
        {
            rights |= GENERIC_ACCESS_RIGHTS.GENERIC_READ;
        }

        if (desiredAccess.HasFlag(FileAccess.Write))
        {
            rights |= GENERIC_ACCESS_RIGHTS.GENERIC_WRITE;
        }

        using var p = new Pwstr(fileName);
        unsafe
        {
            var pg = Unsafe.AsPointer(ref guidVendor);
            factory.CreateDecoderFromFilename(p, (nint)pg, rights, metadataOptions, out var value).ThrowOnError();
            return new ComObject<IWICBitmapDecoder>(value);
        }
    }

    public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(this IComObject<IWICImagingFactory> factory, IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromStream(factory?.Object!, stream, guidVendor, metadataOptions);
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(this IWICImagingFactory factory, IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(stream);
        IWICBitmapDecoder value;
        if (guidVendor.HasValue)
        {
            factory.CreateDecoderFromStream(stream, guidVendor.Value, metadataOptions, out value).ThrowOnError();
        }
        else
        {
            factory.CreateDecoderFromStream(stream, Unsafe.NullRef<Guid>(), metadataOptions, out value).ThrowOnError();
        }
        return new ComObject<IWICBitmapDecoder>(value);
    }

    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(this IComObject<IWICImagingFactory> factory, nuint handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromFileHandle(factory?.Object!, handle, guidVendor, metadataOptions);
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(this IWICImagingFactory factory, nuint handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(factory);
        IWICBitmapDecoder value;
        if (guidVendor.HasValue)
        {
            factory.CreateDecoderFromFileHandle(handle, guidVendor.Value, metadataOptions, out value).ThrowOnError();
        }
        else
        {
            factory.CreateDecoderFromFileHandle(handle, Unsafe.NullRef<Guid>(), metadataOptions, out value).ThrowOnError();
        }
        return new ComObject<IWICBitmapDecoder>(value);
    }

    public static IComObject<IEnumUnknown> CreateComponentEnumerator(this IComObject<IWICImagingFactory> factory, WICComponentType type = WICComponentType.WICAllComponents, WICComponentEnumerateOptions options = WICComponentEnumerateOptions.WICComponentEnumerateDefault) => CreateComponentEnumerator(factory?.Object!, type, options);
    public static IComObject<IEnumUnknown> CreateComponentEnumerator(this IWICImagingFactory factory, WICComponentType type = WICComponentType.WICAllComponents, WICComponentEnumerateOptions options = WICComponentEnumerateOptions.WICComponentEnumerateDefault)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateComponentEnumerator((uint)type, (uint)options, out var value).ThrowOnError();
        return new ComObject<IEnumUnknown>(value);
    }

    public static IComObject<IWICBitmapEncoder> CreateEncoder(this IComObject<IWICImagingFactory> factory, Guid containerFormat, Guid? vendor = null) => CreateEncoder(factory?.Object!, containerFormat, vendor);
    public static IComObject<IWICBitmapEncoder> CreateEncoder(this IWICImagingFactory factory, Guid containerFormat, Guid? vendor = null)
    {
        ArgumentNullException.ThrowIfNull(factory);
        IWICBitmapEncoder value;
        if (vendor.HasValue)
        {
            factory.CreateEncoder(containerFormat, vendor.Value, out value).ThrowOnError();
        }
        else
        {
            factory.CreateEncoder(containerFormat, Unsafe.NullRef<Guid>(), out value).ThrowOnError();
        }
        return new ComObject<IWICBitmapEncoder>(value);
    }

    public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(this IComObject<IWICImagingFactory> factory, HBITMAP bitmapHandle, HPALETTE paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => CreateBitmapFromHBITMAP(factory?.Object!, bitmapHandle, paletteHandle, options);
    public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(this IWICImagingFactory factory, HBITMAP bitmapHandle, HPALETTE paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmapFromHBITMAP(bitmapHandle, paletteHandle, options, out var value).ThrowOnError();
        return new ComObject<IWICBitmap>(value);
    }

    public static IComObject<IWICBitmap> CreateBitmapFromHICON(this IComObject<IWICImagingFactory> factory, HICON iconHandle) => CreateBitmapFromHICON(factory?.Object!, iconHandle);
    public static IComObject<IWICBitmap> CreateBitmapFromHICON(this IWICImagingFactory factory, HICON iconHandle)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateBitmapFromHICON(iconHandle, out var value).ThrowOnError();
        return new ComObject<IWICBitmap>(value);
    }

    public static IComObject<IWICBitmap> CreateBitmapFromMemory(this IComObject<IWICImagingFactory> factory, uint width, uint height, Guid pixelFormat, uint stride, byte[] buffer) => CreateBitmapFromMemory(factory?.Object!, width, height, pixelFormat, stride, buffer);
    public static IComObject<IWICBitmap> CreateBitmapFromMemory(this IWICImagingFactory factory, uint width, uint height, Guid pixelFormat, uint stride, byte[] buffer)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(buffer);
        unsafe
        {
            fixed (byte* ptr = buffer)
            {
                factory.CreateBitmapFromMemory(width, height, pixelFormat, stride, (uint)buffer.Length, (nint)ptr, out var value).ThrowOnError();
                return new ComObject<IWICBitmap>(value);
            }
        }
    }

    public static IComObject<IWICBitmap> CreateBitmapFromSource(this IComObject<IWICImagingFactory> factory, IComObject<IWICBitmapSource> source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => CreateBitmapFromSource(factory?.Object!, source?.Object!, option);
    public static IComObject<IWICBitmap> CreateBitmapFromSource(this IWICImagingFactory factory, IWICBitmapSource source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(source);
        factory.CreateBitmapFromSource(source, option, out var value).ThrowOnError();
        return new ComObject<IWICBitmap>(value);
    }

    public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(this IComObject<IWICImagingFactory> factory, IComObject<IWICBitmapSource> source, int x, int y, uint width, uint height) => CreateBitmapFromSourceRect(factory?.Object!, source?.Object!, x, y, width, height);
    public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(this IWICImagingFactory factory, IWICBitmapSource source, int x, int y, uint width, uint height)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(source);
        factory.CreateBitmapFromSourceRect(source, (uint)x, (uint)y, width, height, out var value).ThrowOnError();
        return new ComObject<IWICBitmap>(value);
    }

    public static IComObject<IWICColorContext> CreateColorContext(this IComObject<IWICImagingFactory> factory) => CreateColorContext(factory?.Object!);
    public static IComObject<IWICColorContext> CreateColorContext(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateColorContext(out var value).ThrowOnError();
        return new ComObject<IWICColorContext>(value);
    }

    public static IComObject<IWICColorTransform> CreateColorTransformer(this IComObject<IWICImagingFactory> factory) => CreateColorTransformer(factory?.Object!);
    public static IComObject<IWICColorTransform> CreateColorTransformer(this IWICImagingFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateColorTransformer(out var value).ThrowOnError();
        return new ComObject<IWICColorTransform>(value);
    }

    public static IEnumerable<IComObject<IWICComponentInfo>> EnumerateComponents(this IComObject<IWICImagingFactory> factory, WICComponentType type, WICComponentEnumerateOptions options) => EnumerateComponents(factory?.Object!, type, options);
    public static IEnumerable<IComObject<IWICComponentInfo>> EnumerateComponents(this IWICImagingFactory factory, WICComponentType type, WICComponentEnumerateOptions options)
    {
        ArgumentNullException.ThrowIfNull(factory);
        using var enumerator = factory.CreateComponentEnumerator(type, options);
        var sw = new StrategyBasedComWrappers();
        do
        {
            var array = new nint[1];
            if (!enumerator.Object.Next(1, array, 0).IsOk)
                break;

            var obj = sw.GetOrCreateObjectForComInstance(array[0], CreateObjectFlags.UniqueInstance);
            if (obj is IWICComponentInfo info)
                yield return new ComObject<IWICComponentInfo>(info);
        }
        while (true);
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IWICImageEncoder> CreateImageEncoder(this IComObject<IWICImagingFactory2> factory, IComObject<ID2D1Device> device) => CreateImageEncoder(factory?.Object!, device?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IWICImageEncoder> CreateImageEncoder(this IWICImagingFactory2 factory, ID2D1Device device)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(device);
        factory.CreateImageEncoder(device, out var value).ThrowOnError();
        return new ComObject<IWICImageEncoder>(value);
    }
}
