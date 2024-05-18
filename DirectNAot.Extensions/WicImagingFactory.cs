namespace DirectNAot.Extensions;

public static class WicImagingFactory
{
    public static IComObject<IWICPalette> CreatePalette() => WithFactory(f => f.CreatePalette());
    public static IComObject<IWICColorContext> CreateColorContext() => WithFactory(f => f.CreateColorContext());
    public static IComObject<IWICBitmapClipper> CreateBitmapClipper() => WithFactory(f => f.CreateBitmapClipper());
    public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator() => WithFactory(f => f.CreateBitmapFlipRotator());
    public static IComObject<IWICBitmapScaler> CreateBitmapScaler() => WithFactory(f => f.CreateBitmapScaler());
    public static IComObject<IWICBitmap> CreateBitmap(uint width, uint height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => WithFactory(f => f.CreateBitmap(width, height, pixelFormat, option));
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromFilename(fileName, guidVendor, desiredAccess, metadataOptions));
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromStream(stream, guidVendor, metadataOptions));
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(nuint handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromFileHandle(handle, guidVendor, metadataOptions));
    public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(Stream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromStream(new ManagedIStream(stream), guidVendor, metadataOptions));
    public static IComObject<IWICBitmapEncoder> CreateEncoder(Guid containerFormat) => WithFactory(f => f.CreateEncoder(containerFormat));
    public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(HBITMAP bitmapHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => WithFactory(f => f.CreateBitmapFromHBITMAP(bitmapHandle, HPALETTE.Null, options));
    public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(HBITMAP bitmapHandle, HPALETTE paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => WithFactory(f => f.CreateBitmapFromHBITMAP(bitmapHandle, paletteHandle, options));
    public static IComObject<IWICBitmap> CreateBitmapFromHICON(HICON iconHandle) => WithFactory(f => f.CreateBitmapFromHICON(iconHandle));
    public static IComObject<IWICBitmap> CreateBitmapFromMemory(uint width, uint height, Guid pixelFormat, uint stride, byte[] buffer) => WithFactory(f => f.CreateBitmapFromMemory(width, height, pixelFormat, stride, buffer));
    public static IComObject<IWICBitmap> CreateBitmapFromSource(IComObject<IWICBitmapSource> source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => WithFactory(f => f.CreateBitmapFromSource(source?.Object!, option));
    public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(IComObject<IWICBitmapSource> source, int x, int y, uint width, uint height) => WithFactory(f => f.CreateBitmapFromSourceRect(source?.Object!, x, y, width, height));

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IWICImageEncoder> CreateImageEncoder(IComObject<ID2D1Device> device) => WithFactory2(f => f.CreateImageEncoder(device?.Object!));

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IWICColorTransform> CreateColorTransformer() => WithFactory2(f => f.CreateColorTransformer());

    public static IComObject<IWICColorContext>[] CreateColorContexts(int count) => WithFactory(f =>
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        var colorContexts = new IComObject<IWICColorContext>[count];
        for (var i = 0; i < count; i++)
        {
            colorContexts[i] = f.CreateColorContext();
        }
        return colorContexts;
    });

    public static void WithFactory(Action<IWICImagingFactory> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        using var factory = Create();
        action(factory!.Object);
    }

    public static T WithFactory<T>(Func<IWICImagingFactory, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        using var factory = Create();
        return func(factory!.Object);
    }

    [SupportedOSPlatform("windows8.0")]
    public static void WithFactory2(Action<IWICImagingFactory2> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        using var factory = Create<IWICImagingFactory2>(Constants.CLSID_WICImagingFactory2);
        action(factory!.Object);
    }

    [SupportedOSPlatform("windows8.0")]
    public static T WithFactory2<T>(Func<IWICImagingFactory2, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        using var factory = Create<IWICImagingFactory2>(Constants.CLSID_WICImagingFactory2);
        return func(factory!.Object);
    }

    public static IComObject<IWICImagingFactory>? Create(Guid? clsid = null, bool throwOnError = true) => Create<IWICImagingFactory>(clsid, throwOnError);
    public static IComObject<T>? Create<T>(Guid? clsid = null, bool throwOnError = true) where T : IWICImagingFactory
    {
        clsid ??= Constants.CLSID_WICImagingFactory;
        return ComObject<T>.CoCreate(clsid.Value, throwOnError: throwOnError);
    }
}
