namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class ID2D1DeviceContextExtensions
{
    public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(context?.Object!, size, 0, 0, properties);
    public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(context?.Object!, size, srcData, pitch, properties);
    public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap => CreateBitmap<T>(context?.Object!, size, 0, 0, properties);
    public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap => CreateBitmap<T>(context?.Object!, size, srcData, pitch, properties);
    public static IComObject<T> CreateBitmap<T>(this ID2D1DeviceContext context, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateBitmap(size, srcData, pitch, properties, out var bmp).ThrowOnError();
        return new ComObject<T>((T)bmp);
    }

    public static IComObject<ID2D1Bitmap1> CreateBitmapFromDxgiSurface(this IComObject<ID2D1DeviceContext> context, IComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) => CreateBitmapFromDxgiSurface<ID2D1Bitmap1>(context?.Object!, surface?.Object!, properties);
    public static IComObject<T> CreateBitmapFromDxgiSurface<T>(this IComObject<ID2D1DeviceContext> context, IComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1 => CreateBitmapFromDxgiSurface<T>(context?.Object!, surface?.Object!, properties);
    public static IComObject<T> CreateBitmapFromDxgiSurface<T>(this ID2D1DeviceContext context, IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(surface);
        context.CreateBitmapFromDxgiSurface(surface, properties.CopyToPointer(), out var bmp).ThrowOnError();
        return new ComObject<T>((T)bmp);
    }

    public static IComObject<ID2D1Bitmap1> CreateBitmapFromWicBitmap(this IComObject<ID2D1DeviceContext> context, IComObject<IWICBitmapSource> source, D2D1_BITMAP_PROPERTIES1? properties = null) => CreateBitmapFromWicBitmap<ID2D1Bitmap1>(context?.Object!, source?.Object!, properties);
    public static IComObject<T> CreateBitmapFromWicBitmap<T>(this IComObject<ID2D1DeviceContext> context, IComObject<IWICBitmapSource> source, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1 => CreateBitmapFromWicBitmap<T>(context?.Object!, source?.Object!, properties);
    public static IComObject<T> CreateBitmapFromWicBitmap<T>(this ID2D1DeviceContext context, IWICBitmapSource source, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(source);
        context.CreateBitmapFromWicBitmap(source, properties.CopyToPointer(), out ID2D1Bitmap1 bmp).ThrowOnError();
        return new ComObject<T>((T)bmp);
    }

    public static IComObject<ID2D1Brush> CreateSolidColorBrush(this IComObject<ID2D1DeviceContext> context, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1Brush>(context?.Object!, color, properties);
    public static IComObject<T> CreateSolidColorBrush<T>(this IComObject<ID2D1DeviceContext> context, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1Brush => CreateSolidColorBrush<T>(context?.Object!, color, properties);
    public static IComObject<T> CreateSolidColorBrush<T>(this ID2D1DeviceContext context, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1Brush
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateSolidColorBrush(color, properties.CopyToPointer(), out var brush).ThrowOnError();
        return new ComObject<T>((T)brush);
    }

    public static void WithAntialiasMode(this IComObject<ID2D1DeviceContext> context, D2D1_ANTIALIAS_MODE mode, Action action) => WithAntialiasMode(context?.Object!, mode, action);
    public static void WithAntialiasMode(this ID2D1DeviceContext context, D2D1_ANTIALIAS_MODE mode, Action action)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(action);
        var old = context.GetAntialiasMode();
        try
        {
            context.SetAntialiasMode(mode);
            action();
        }
        finally
        {
            context.SetAntialiasMode(old);
        }
    }

    public static void WithTextAntialiasMode(this IComObject<ID2D1DeviceContext> context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action) => WithTextAntialiasMode(context?.Object!, mode, action);
    public static void WithTextAntialiasMode(this ID2D1DeviceContext context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(action);
        var old = context.GetTextAntialiasMode();
        try
        {
            context.SetTextAntialiasMode(mode);
            action();
        }
        finally
        {
            context.SetTextAntialiasMode(old);
        }
    }

    public static void WithPrimitiveBlend(this IComObject<ID2D1DeviceContext> context, D2D1_PRIMITIVE_BLEND mode, Action action) => WithPrimitiveBlend(context?.Object!, mode, action);
    public static void WithPrimitiveBlend(this ID2D1DeviceContext context, D2D1_PRIMITIVE_BLEND mode, Action action)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(action);
        var old = context.GetPrimitiveBlend();
        try
        {
            context.SetPrimitiveBlend(mode);
            action();
        }
        finally
        {
            context.SetPrimitiveBlend(old);
        }
    }

    public static IComObject<ID2D1Device>? GetDevice(this IComObject<ID2D1DeviceContext> context) => GetDevice<ID2D1Device>(context?.Object!);
    public static IComObject<T>? GetDevice<T>(this IComObject<ID2D1DeviceContext> context) where T : ID2D1Device => GetDevice<T>(context?.Object!);
    public static IComObject<T>? GetDevice<T>(this ID2D1DeviceContext context) where T : ID2D1Device
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetDevice(out var device);
        return device != null ? new ComObject<T>((T)device) : null;
    }

    public static IComObject<ID2D1Factory>? GetFactory(this IComObject<ID2D1DeviceContext> context) => GetFactory(context?.Object!);
    public static IComObject<ID2D1Factory>? GetFactory(this ID2D1DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetFactory(out var factory);
        return factory != null ? new ComObject<ID2D1Factory>(factory) : null;
    }

    public static void SetTarget(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Image> target) => SetTarget(context?.Object!, target?.Object!);
    public static void SetTarget(this ID2D1DeviceContext context, ID2D1Image target)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(target);
        context.SetTarget(target);
    }

    public static IComObject<ID2D1Image>? GetTarget(this IComObject<ID2D1DeviceContext> context) => GetTarget<ID2D1Image>(context?.Object!);
    public static IComObject<T>? GetTarget<T>(this IComObject<ID2D1DeviceContext> context) where T : ID2D1Image => GetTarget<T>(context?.Object!);
    public static IComObject<T>? GetTarget<T>(this ID2D1DeviceContext context) where T : ID2D1Image
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetTarget(out var device);
        return device != null ? new ComObject<T>((T)device) : null;
    }

    public static D2D_RECT_F GetImageLocalBounds(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Image> image) => GetImageLocalBounds(context?.Object!, image?.Object!);
    public static D2D_RECT_F GetImageLocalBounds(this ID2D1DeviceContext context, ID2D1Image image)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetImageLocalBounds(image, out var bounds).ThrowOnError();
        return bounds;
    }

    public static D2D_RECT_F GetImageWorldBounds(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Image> image) => GetImageWorldBounds(context?.Object!, image?.Object!);
    public static D2D_RECT_F GetImageWorldBounds(this ID2D1DeviceContext context, ID2D1Image image)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GetImageWorldBounds(image, out var bounds).ThrowOnError();
        return bounds;
    }

    public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1DeviceContext> context) => GetPixelSize(context?.Object!);
    public static D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetPixelSize();
    }

    public static D2D_SIZE_F GetSize(this IComObject<ID2D1DeviceContext> context) => GetSize(context?.Object!);
    public static D2D_SIZE_F GetSize(this ID2D1DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetSize();
    }

    public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1DeviceContext> context) => GetPixelFormat(context?.Object!);
    public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetPixelFormat();
    }

    public static void SetTags(this IComObject<ID2D1DeviceContext> context, ulong tag1, ulong tag2 = 0) => SetTags(context?.Object!, tag1, tag2);
    public static void SetTags(this ID2D1DeviceContext context, ulong tag1, ulong tag2 = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.SetTags(tag1, tag2);
    }

    public static IComObject<ID2D1Effect>? CreateEffect(this IComObject<ID2D1DeviceContext> context, Guid id) => CreateEffect(context?.Object!, id);
    public static IComObject<ID2D1Effect>? CreateEffect(this ID2D1DeviceContext context, Guid id)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateEffect(id, out var effect).ThrowOnError();
        return effect != null ? new ComObject<ID2D1Effect>(effect) : null;
    }

    // this one is useless but is consistent with EndDraw
    public static void BeginDraw(this IComObject<ID2D1DeviceContext> context) => BeginDraw(context?.Object!);
    public static void BeginDraw(this ID2D1DeviceContext context) => context?.BeginDraw();
    public static void EndDraw(this IComObject<ID2D1DeviceContext> context) => EndDraw(context?.Object!);
    public static void EndDraw(this ID2D1DeviceContext context) => context?.EndDraw(0, 0).ThrowOnError();
    public static void Clear(this IComObject<ID2D1DeviceContext> context) => Clear(context?.Object!);
    public static void Clear(this ID2D1DeviceContext context) => context?.Clear(0);

    public static void DrawText(this IComObject<ID2D1DeviceContext> context,
        string text,
        IComObject<IDWriteTextFormat> format,
        D2D_RECT_F rect,
        IComObject<ID2D1Brush> defaultFillBrush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(context?.Object!, text, format?.Object!, rect, defaultFillBrush?.Object!, options, measuringMode);

    public static void DrawText(this ID2D1DeviceContext context,
        string text,
        IDWriteTextFormat format,
        D2D_RECT_F rect,
        ID2D1Brush defaultFillBrush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(format);
        ArgumentNullException.ThrowIfNull(defaultFillBrush);
        if (text == null)
            return;

        context.DrawText(PWSTR.From(text), (uint)text.Length, format, rect, defaultFillBrush, options, measuringMode);
    }

    public static void DrawTextLayout(this IComObject<ID2D1DeviceContext> context,
        D2D_POINT_2F origin,
        IDWriteTextLayout layout,
        ID2D1Brush? defaultFillBrush = null,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => DrawTextLayout(context?.Object!, origin, layout, defaultFillBrush, options);

    public static void DrawTextLayout(this ID2D1DeviceContext context,
        D2D_POINT_2F origin,
        IDWriteTextLayout layout,
        ID2D1Brush? defaultFillBrush = null,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(layout);
        context.DrawTextLayout(origin, layout, defaultFillBrush, options);
    }

    public static void DrawSvgDocument(this IComObject<ID2D1DeviceContext5> context, IComObject<ID2D1SvgDocument> svgDocument) => DrawSvgDocument(context?.Object!, svgDocument?.Object!);
    public static void DrawSvgDocument(this ID2D1DeviceContext5 context, ID2D1SvgDocument svgDocument)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(svgDocument);
        context.DrawSvgDocument(svgDocument);
    }

    public static void DrawGeometry(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawGeometry(context?.Object!, geometry?.Object!, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawGeometry(this ID2D1DeviceContext context, ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawGeometry(geometry, brush, strokeWidth, strokeStyle);
    }

    public static void FillGeometry(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Brush> brush, IComObject<ID2D1Brush>? opacityBrush = null) => FillGeometry(context?.Object!, geometry?.Object!, brush?.Object!, opacityBrush?.Object!);
    public static void FillGeometry(this ID2D1DeviceContext context, ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush? opacityBrush = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillGeometry(geometry, brush, opacityBrush);
    }

    public static void DrawLine(this IComObject<ID2D1DeviceContext> context, D2D_POINT_2F point0, D2D_POINT_2F point1, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawLine(context?.Object!, point0, point1, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawLine(this ID2D1DeviceContext context, D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawLine(point0, point1, brush, strokeWidth, strokeStyle);
    }

    public static void DrawRoundedRectangle(this IComObject<ID2D1DeviceContext> context, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawRoundedRectangle(context?.Object!, roundedRect, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawRoundedRectangle(this ID2D1DeviceContext context, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawRoundedRectangle(roundedRect, brush, strokeWidth, strokeStyle);
    }

    public static void FillRoundedRectangle(this IComObject<ID2D1DeviceContext> context, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush) => FillRoundedRectangle(context?.Object!, roundedRect, brush?.Object!);
    public static void FillRoundedRectangle(this ID2D1DeviceContext context, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillRoundedRectangle(roundedRect, brush);
    }

    public static void DrawRectangle(this IComObject<ID2D1DeviceContext> context, D2D_RECT_F rect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawRectangle(context?.Object!, rect, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawRectangle(this ID2D1DeviceContext context, D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawRectangle(rect, brush, strokeWidth, strokeStyle);
    }

    public static void FillRectangle(this IComObject<ID2D1DeviceContext> context, D2D_RECT_F rect, IComObject<ID2D1Brush> brush) => FillRectangle(context?.Object!, rect, brush?.Object!);
    public static void FillRectangle(this ID2D1DeviceContext context, D2D_RECT_F rect, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillRectangle(rect, brush);
    }

    public static void DrawEllipse(this IComObject<ID2D1DeviceContext> context, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawEllipse(context?.Object!, ellipse, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawEllipse(this ID2D1DeviceContext context, D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawEllipse(ellipse, brush, strokeWidth, strokeStyle);
    }

    public static void FillEllipse(this IComObject<ID2D1DeviceContext> context, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush) => FillEllipse(context?.Object!, ellipse, brush?.Object!);
    public static void FillEllipse(this ID2D1DeviceContext context, D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillEllipse(ellipse, brush);
    }

    public static IComObject<ID2D1ColorContext> CreateColorContextFromWicColorContext(this IComObject<ID2D1DeviceContext> context, IComObject<IWICColorContext> colorContext) => CreateColorContextFromWicColorContext(context?.Object!, colorContext?.Object!);
    public static IComObject<ID2D1ColorContext> CreateColorContextFromWicColorContext(this ID2D1DeviceContext context, IWICColorContext colorContext)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(colorContext);
        context.CreateColorContextFromWicColorContext(colorContext, out var d2dColorContext).ThrowOnError();
        return new ComObject<ID2D1ColorContext>(d2dColorContext);
    }

    public static IComObject<ID2D1ColorContext> CreateColorContext(this IComObject<ID2D1DeviceContext> context, D2D1_COLOR_SPACE space, byte[]? profile = null) => CreateColorContext(context?.Object!, space, profile);
    public static IComObject<ID2D1ColorContext> CreateColorContext(this ID2D1DeviceContext context, D2D1_COLOR_SPACE space, byte[]? profile = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateColorContext(space, profile.AsPointer(), profile.Length(), out var d2dColorContext).ThrowOnError();
        return new ComObject<ID2D1ColorContext>(d2dColorContext);
    }

    public static IComObject<ID2D1ColorContext> CreateColorContextFromFilename(this IComObject<ID2D1DeviceContext> context, string filePath) => CreateColorContextFromFilename(context?.Object!, filePath);
    public static IComObject<ID2D1ColorContext> CreateColorContextFromFilename(this ID2D1DeviceContext context, string filePath)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateColorContextFromFilename(PWSTR.From(filePath), out var d2dColorContext).ThrowOnError();
        return new ComObject<ID2D1ColorContext>(d2dColorContext);
    }

    public static IComObject<ID2D1ColorContext1> CreateColorContextFromDxgiColorSpace(this IComObject<ID2D1DeviceContext5> context, DXGI_COLOR_SPACE_TYPE colorSpace) => CreateColorContextFromDxgiColorSpace(context?.Object!, colorSpace);
    public static IComObject<ID2D1ColorContext1> CreateColorContextFromDxgiColorSpace(this ID2D1DeviceContext5 context, DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateColorContextFromDxgiColorSpace(colorSpace, out var d2dColorContext).ThrowOnError();
        return new ComObject<ID2D1ColorContext1>(d2dColorContext);
    }

    public static void DrawBitmap(this IComObject<ID2D1DeviceContext> context,
        IComObject<ID2D1Bitmap1> bitmap,
        float opacity = 1,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null,
        D2D_MATRIX_4X4_F? perspectiveTransform = null) => DrawBitmap(context?.Object!, bitmap?.Object!, opacity, interpolationMode, destinationRectangle, sourceRectangle, perspectiveTransform);

    public static void DrawBitmap(this IComObject<ID2D1DeviceContext> context,
        IComObject<ID2D1Bitmap> bitmap,
        float opacity = 1,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null,
        D2D_MATRIX_4X4_F? perspectiveTransform = null) => DrawBitmap(context?.Object!, bitmap?.Object!, opacity, interpolationMode, destinationRectangle, sourceRectangle, perspectiveTransform);

    public static void DrawBitmap(this ID2D1DeviceContext context,
        ID2D1Bitmap bitmap,
        float opacity = 1,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null,
        D2D_MATRIX_4X4_F? perspectiveTransform = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(bitmap);
        if (perspectiveTransform.HasValue || (int)interpolationMode > (int)D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_LINEAR)
        {
            context.DrawBitmap(bitmap, destinationRectangle.CopyToPointer(), opacity, interpolationMode, sourceRectangle.CopyToPointer(), perspectiveTransform.CopyToPointer());
        }
        else
        {
            context.DrawBitmap(bitmap, destinationRectangle.CopyToPointer(), opacity, (D2D1_BITMAP_INTERPOLATION_MODE)interpolationMode, sourceRectangle.CopyToPointer());
        }
    }

    public static void DrawImage(this IComObject<ID2D1DeviceContext> context,
        IComObject<ID2D1Image> image,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
        D2D_POINT_2F? targetOffset = null,
        D2D_RECT_F? imageRectangle = null) => DrawImage(context?.Object!, image?.Object!, interpolationMode, compositeMode, targetOffset, imageRectangle);

    public static void DrawImage(this ID2D1DeviceContext context,
        ID2D1Image image,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
        D2D_POINT_2F? targetOffset = null,
        D2D_RECT_F? imageRectangle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(image);
        context.DrawImage(image, targetOffset.CopyToPointer(), imageRectangle.CopyToPointer(), interpolationMode, compositeMode);
    }

    public static void DrawImage(this IComObject<ID2D1DeviceContext> context,
        IComObject<ID2D1Effect> effect,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
        D2D_POINT_2F? targetOffset = null,
        D2D_RECT_F? imageRectangle = null) => DrawImage(context?.Object!, effect?.Object!, interpolationMode, compositeMode, targetOffset, imageRectangle);

    public static void DrawImage(this ID2D1DeviceContext context,
        ID2D1Effect effect,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
        D2D_POINT_2F? targetOffset = null,
        D2D_RECT_F? imageRectangle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(effect);
        effect.GetOutput(out var image);
        try
        {
            context.DrawImage(image, targetOffset.CopyToPointer(), imageRectangle.CopyToPointer(), interpolationMode, compositeMode);
        }
        finally
        {
            image.FinalRelease();
        }
    }

    public static void PushLayer(this IComObject<ID2D1DeviceContext> context, D2D1_LAYER_PARAMETERS1 parameters) => PushLayer(context?.Object!, parameters);
    public static void PushLayer(this ID2D1DeviceContext context, D2D1_LAYER_PARAMETERS1 parameters)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PushLayer(parameters, null);
    }

    public static void PopLayer(this IComObject<ID2D1DeviceContext> context) => PopLayer(context?.Object!);
    public static void PopLayer(this ID2D1DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PopLayer();
    }

    public static IComObject<ID2D1SvgDocument> CreateSvgDocument(this IComObject<ID2D1DeviceContext5> context, IStream stream, D2D_SIZE_F viewPortSize) => CreateSvgDocument(context?.Object!, stream, viewPortSize);
    public static IComObject<ID2D1SvgDocument> CreateSvgDocument(this ID2D1DeviceContext5 context, IStream stream, D2D_SIZE_F viewPortSize)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(stream);
        context.CreateSvgDocument(stream, viewPortSize, out var doc).ThrowOnError();
        return new ComObject<ID2D1SvgDocument>(doc);
    }
}