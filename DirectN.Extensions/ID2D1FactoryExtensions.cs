namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1FactoryExtensions
{
    public static IComObject<ID2D1RenderTarget> CreateWicBitmapRenderTarget(this IComObject<ID2D1Factory> factory, IComObject<IWICBitmap> target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) => CreateWicBitmapRenderTarget<ID2D1RenderTarget>(factory?.Object!, target?.Object!, renderTargetProperties);
    public static IComObject<T> CreateWicBitmapRenderTarget<T>(this IComObject<ID2D1Factory> factory, IComObject<IWICBitmap> target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) where T : ID2D1RenderTarget => CreateWicBitmapRenderTarget<T>(factory?.Object!, target?.Object!, renderTargetProperties);
    public static IComObject<T> CreateWicBitmapRenderTarget<T>(this ID2D1Factory factory, IWICBitmap target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) where T : ID2D1RenderTarget
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(target);
        var props = renderTargetProperties ?? new D2D1_RENDER_TARGET_PROPERTIES();
        factory.CreateWicBitmapRenderTarget(target, props, out var renderTarget).ThrowOnError();
        return new ComObject<T>((T)renderTarget);
    }

    public static IComObject<ID2D1HwndRenderTarget> CreateHwndRenderTarget(this IComObject<ID2D1Factory> factory, D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) => CreateHwndRenderTarget(factory?.Object!, hwndRenderTargetProperties, renderTargetProperties);
    public static IComObject<ID2D1HwndRenderTarget> CreateHwndRenderTarget(this ID2D1Factory factory, D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null)
    {
        ArgumentNullException.ThrowIfNull(factory);
        var props = renderTargetProperties ?? new D2D1_RENDER_TARGET_PROPERTIES();
        factory.CreateHwndRenderTarget(props, hwndRenderTargetProperties, out var renderTarget).ThrowOnError();
        return new ComObject<ID2D1HwndRenderTarget>(renderTarget);
    }

    public static IComObject<ID2D1RenderTarget> CreateDxgiSurfaceRenderTarget(this IComObject<ID2D1Factory> factory, IComObject<IDXGISurface> surface, D2D1_RENDER_TARGET_PROPERTIES? properties = null) => CreateDxgiSurfaceRenderTarget(factory?.Object!, surface?.Object!, properties);
    public static IComObject<ID2D1RenderTarget> CreateDxgiSurfaceRenderTarget(this ID2D1Factory factory, IDXGISurface surface, D2D1_RENDER_TARGET_PROPERTIES? properties = null)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(surface);
        var props = properties ?? new D2D1_RENDER_TARGET_PROPERTIES();
        factory.CreateDxgiSurfaceRenderTarget(surface, props, out var renderTarget).ThrowOnError();
        return new ComObject<ID2D1RenderTarget>(renderTarget);
    }

    public static IComObject<ID2D1DCRenderTarget> CreateDCRenderTarget(this IComObject<ID2D1Factory> factory, D2D1_RENDER_TARGET_PROPERTIES properties) => CreateDCRenderTarget<ID2D1DCRenderTarget>(factory?.Object!, properties);
    public static IComObject<T> CreateDCRenderTarget<T>(this IComObject<ID2D1Factory> factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget => CreateDCRenderTarget<T>(factory?.Object!, properties);
    public static IComObject<T> CreateDCRenderTarget<T>(this ID2D1Factory factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateDCRenderTarget(properties, out var target).ThrowOnError();
        return new ComObject<T>((T)target);
    }

    public static IComObject<ID2D1StrokeStyle> CreateStrokeStyle(this IComObject<ID2D1Factory> factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float>? dashes = null) => CreateStrokeStyle<ID2D1StrokeStyle>(factory?.Object!, properties, dashes);
    public static IComObject<T> CreateStrokeStyle<T>(this IComObject<ID2D1Factory> factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float>? dashes = null) where T : ID2D1StrokeStyle => CreateStrokeStyle<T>(factory?.Object!, properties, dashes);
    public static IComObject<T> CreateStrokeStyle<T>(this ID2D1Factory factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float>? dashes = null) where T : ID2D1StrokeStyle
    {
        ArgumentNullException.ThrowIfNull(factory);
        var array = dashes?.ToArray();
        factory.CreateStrokeStyle(properties, array.AsPointer(), array.Length(), out var style).ThrowOnError();
        return new ComObject<T>((T)style);
    }

    public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this IComObject<ID2D1Factory> factory, D2D1_ELLIPSE ellipse) => CreateEllipseGeometry(factory?.Object!, ellipse);
    public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this ID2D1Factory factory, D2D1_ELLIPSE ellipse)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateEllipseGeometry(ellipse, out var geometry).ThrowOnError();
        return new ComObject<ID2D1EllipseGeometry>(geometry);
    }

    public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this IComObject<ID2D1Factory> factory, D2D_RECT_F rectangle) => CreateRectangleGeometry(factory?.Object!, rectangle);
    public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this ID2D1Factory factory, D2D_RECT_F rectangle)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateRectangleGeometry(rectangle, out var geometry).ThrowOnError();
        return new ComObject<ID2D1RectangleGeometry>(geometry);
    }

    public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this IComObject<ID2D1Factory> factory, D2D1_ROUNDED_RECT rectangle) => CreateRoundedRectangleGeometry(factory?.Object!, rectangle);
    public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this ID2D1Factory factory, D2D1_ROUNDED_RECT rectangle)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateRoundedRectangleGeometry(rectangle, out var geometry).ThrowOnError();
        return new ComObject<ID2D1RoundedRectangleGeometry>(geometry);
    }

    public static IComObject<ID2D1PathGeometry> CreatePathGeometry(this IComObject<ID2D1Factory> factory) => CreatePathGeometry<ID2D1PathGeometry>(factory?.Object!);
    public static IComObject<T> CreatePathGeometry<T>(this IComObject<ID2D1Factory> factory) where T : ID2D1PathGeometry => CreatePathGeometry<T>(factory?.Object!);
    public static IComObject<T> CreatePathGeometry<T>(this ID2D1Factory factory) where T : ID2D1PathGeometry
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreatePathGeometry(out var geometry).ThrowOnError();
        return new ComObject<T>((T)geometry);
    }

    public static IComObject<ID2D1TransformedGeometry> CreateTransformedGeometry(this IComObject<ID2D1Factory> factory, IComObject<ID2D1Geometry> sourceGeometry, in D2D_MATRIX_3X2_F transform) => CreateTransformedGeometry(factory?.Object!, sourceGeometry?.Object!, transform);
    public static IComObject<ID2D1TransformedGeometry> CreateTransformedGeometry(this ID2D1Factory factory, ID2D1Geometry sourceGeometry, in D2D_MATRIX_3X2_F transform)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(sourceGeometry);
        factory.CreateTransformedGeometry(sourceGeometry, transform, out var geometry).ThrowOnError();
        return new ComObject<ID2D1TransformedGeometry>(geometry);
    }

    public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this IComObject<ID2D1Factory> factory, D2D1_FILL_MODE fillMode, IReadOnlyList<IComObject<ID2D1Geometry>> geometries) => CreateGeometryGroup(factory?.Object!, fillMode, geometries.UnwrapAsArray()!);
    public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this ID2D1Factory factory, D2D1_FILL_MODE fillMode, IReadOnlyList<ID2D1Geometry> geometries)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(geometries);
        if (geometries == null || geometries.Count == 0)
            throw new ArgumentException(null, nameof(geometries));

        factory.CreateGeometryGroup(fillMode, [.. geometries], (uint)geometries.Count, out var geometry).ThrowOnError();
        return new ComObject<ID2D1GeometryGroup>(geometry);
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1Device> CreateDevice(this IComObject<ID2D1Factory1> factory, IComObject<IDXGIDevice> device) => CreateDevice<ID2D1Device>(factory?.Object!, device?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateDevice<T>(this IComObject<ID2D1Factory1> factory, IComObject<IDXGIDevice> device) where T : ID2D1Device => CreateDevice<T>(factory?.Object!, device?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateDevice<T>(this ID2D1Factory1 factory, IDXGIDevice device) where T : ID2D1Device
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(device);
        factory.CreateDevice(device, out var dev).ThrowOnError();
        return new ComObject<T>((T)dev);
    }

    [SupportedOSPlatform("windows8.0")]
    public static Guid[] GetRegisteredEffects(this IComObject<ID2D1Factory1> factory) => GetRegisteredEffects(factory?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static Guid[] GetRegisteredEffects(this ID2D1Factory1 factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        var ptr = Marshal.AllocHGlobal(8);
        try
        {
            factory.GetRegisteredEffects(0, 0, ptr, ptr + 4).ThrowOnError();
            var ret = Marshal.ReadInt32(ptr);
            var reg = Marshal.ReadInt32(ptr + 4);
            var clsids = new Guid[reg];
            factory.GetRegisteredEffects(clsids.AsPointer(), clsids.Length(), ptr, ptr + 4).ThrowOnError();
            return clsids;
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public static void RunMultithreadProtected(this IComObject<ID2D1Factory> factory, Action action) => RunMultithreadProtected(factory?.Object!, action);

    [SupportedOSPlatform("windows8.0")]
    public static void RunMultithreadProtected(this ID2D1Factory factory, Action action)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ((ID2D1Multithread)factory).RunMultithreadProtected(action);
    }

    [SupportedOSPlatform("windows8.0")]
    public static Task RunMultithreadProtected(this IComObject<ID2D1Factory> factory, Func<Task> action) => RunMultithreadProtected(factory?.Object!, action);

    [SupportedOSPlatform("windows8.0")]
    public static Task RunMultithreadProtected(this ID2D1Factory factory, Func<Task> action)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return ((ID2D1Multithread)factory).RunMultithreadProtected(action);
    }

    [SupportedOSPlatform("windows8.0")]
    public static T RunMultithreadProtected<T>(this IComObject<ID2D1Factory> factory, Func<T> func) => RunMultithreadProtected(factory?.Object!, func);

    [SupportedOSPlatform("windows8.0")]
    public static T RunMultithreadProtected<T>(this ID2D1Factory factory, Func<T> func)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return ((ID2D1Multithread)factory).RunMultithreadProtected(func);
    }

    [SupportedOSPlatform("windows8.0")]
    public static Task<T> RunMultithreadProtected<T>(this IComObject<ID2D1Factory> factory, Func<Task<T>> func) => RunMultithreadProtected(factory?.Object!, func);

    [SupportedOSPlatform("windows8.0")]
    public static Task<T> RunMultithreadProtected<T>(this ID2D1Factory factory, Func<Task<T>> func)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return ((ID2D1Multithread)factory).RunMultithreadProtected(func);
    }

    [SupportedOSPlatform("windows8.0")]
    public static bool IsMultithreadProtected(this IComObject<ID2D1Factory> factory) => IsMultithreadProtected(factory?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static bool IsMultithreadProtected(this ID2D1Factory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return ((ID2D1Multithread)factory).GetMultithreadProtected();
    }
}
