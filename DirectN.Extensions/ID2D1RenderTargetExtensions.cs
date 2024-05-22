namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1RenderTargetExtensions
{
    public static D2D1_WINDOW_STATE CheckWindowState(this IComObject<ID2D1HwndRenderTarget> renderTarget) => CheckWindowState(renderTarget?.Object!);
    public static D2D1_WINDOW_STATE CheckWindowState(this ID2D1HwndRenderTarget renderTarget)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        return renderTarget.CheckWindowState();
    }

    public static HWND GetHwnd(this IComObject<ID2D1HwndRenderTarget> renderTarget) => GetHwnd(renderTarget?.Object!);
    public static HWND GetHwnd(this ID2D1HwndRenderTarget renderTarget)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        return renderTarget.GetHwnd();
    }

    public static void Resize(this IComObject<ID2D1HwndRenderTarget> renderTarget, D2D_SIZE_U size) => Resize(renderTarget?.Object!, size);
    public static void Resize(this ID2D1HwndRenderTarget renderTarget, D2D_SIZE_U size)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        renderTarget.Resize(size).ThrowOnError();
    }

    public static IComObject<ID2D1Bitmap> GetBitmap(this IComObject<ID2D1BitmapRenderTarget> renderTarget) => GetBitmap<ID2D1Bitmap>(renderTarget?.Object!);
    public static IComObject<T> GetBitmap<T>(this IComObject<ID2D1BitmapRenderTarget> renderTarget) where T : ID2D1Bitmap => GetBitmap<T>(renderTarget?.Object!);
    public static IComObject<T> GetBitmap<T>(this ID2D1BitmapRenderTarget renderTarget) where T : ID2D1Bitmap
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        renderTarget.GetBitmap(out var bmp).ThrowOnError();
        return new ComObject<T>((T)bmp);
    }

    public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(device?.Object!, size, 0, 0, properties);
    public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(device?.Object!, size, srcData, pitch, properties);
    public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap => CreateBitmap<T>(device?.Object!, size, srcData, pitch, properties);
    public static IComObject<T> CreateBitmap<T>(this ID2D1RenderTarget device, D2D_SIZE_U size, nint srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateBitmap(size, srcData, pitch, properties, out var bmp).ThrowOnError();
        return new ComObject<T>((T)bmp);
    }

    public static IComObject<ID2D1BitmapRenderTarget> CreateCompatibleRenderTarget(this IComObject<ID2D1RenderTarget> context, D2D_SIZE_F? desiredSize = null, D2D_SIZE_U? desiredPixelSize = null, D2D1_PIXEL_FORMAT? desiredFormat = null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options = D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE) => CreateCompatibleRenderTarget(context?.Object!, desiredSize, desiredPixelSize, desiredFormat, options);
    public static IComObject<ID2D1BitmapRenderTarget> CreateCompatibleRenderTarget(this ID2D1RenderTarget context, D2D_SIZE_F? desiredSize = null, D2D_SIZE_U? desiredPixelSize = null, D2D1_PIXEL_FORMAT? desiredFormat = null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options = D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.CreateCompatibleRenderTarget(desiredSize.CopyToPointer(), desiredPixelSize.CopyToPointer(), desiredFormat.CopyToPointer(), options, out var target).ThrowOnError();
        return new ComObject<ID2D1BitmapRenderTarget>(target);
    }

    public static IComObject<ID2D1SolidColorBrush> CreateSolidColorBrush(this IComObject<ID2D1RenderTarget> device, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1SolidColorBrush>(device?.Object!, color, properties);
    public static IComObject<T> CreateSolidColorBrush<T>(this IComObject<ID2D1RenderTarget> device, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush => CreateSolidColorBrush<T>(device?.Object!, color, properties);
    public static IComObject<T> CreateSolidColorBrush<T>(this ID2D1RenderTarget device, D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateSolidColorBrush(color, properties.CopyToPointer(), out var brush).ThrowOnError();
        return new ComObject<T>((T)brush);
    }

    public static IComObject<ID2D1RadialGradientBrush> CreateRadialGradientBrush(this IComObject<ID2D1RenderTarget> context, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, IComObject<ID2D1GradientStopCollection> stops, D2D1_BRUSH_PROPERTIES? brushProperties = null) => CreateRadialGradientBrush(context?.Object!, gradientBrushProperties, stops?.Object!, brushProperties);
    public static IComObject<ID2D1RadialGradientBrush> CreateRadialGradientBrush(this ID2D1RenderTarget context, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, ID2D1GradientStopCollection stops, D2D1_BRUSH_PROPERTIES? brushProperties = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(stops);
        context.CreateRadialGradientBrush(gradientBrushProperties, brushProperties.CopyToPointer(), stops, out var brush).ThrowOnError();
        return new ComObject<ID2D1RadialGradientBrush>(brush);
    }

    public static IComObject<ID2D1LinearGradientBrush> CreateLinearGradientBrush(this IComObject<ID2D1RenderTarget> context, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, IComObject<ID2D1GradientStopCollection> stops, D2D1_BRUSH_PROPERTIES? brushProperties = null) => CreateLinearGradientBrush(context?.Object!, gradientBrushProperties, stops?.Object!, brushProperties);
    public static IComObject<ID2D1LinearGradientBrush> CreateLinearGradientBrush(this ID2D1RenderTarget context, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, ID2D1GradientStopCollection stops, D2D1_BRUSH_PROPERTIES? brushProperties = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(stops);
        context.CreateLinearGradientBrush(gradientBrushProperties, brushProperties.CopyToPointer(), stops, out var brush).ThrowOnError();
        return new ComObject<ID2D1LinearGradientBrush>(brush);
    }

    public static IComObject<ID2D1GradientStopCollection> CreateGradientStopCollection(this IComObject<ID2D1RenderTarget> context, IEnumerable<D2D1_GRADIENT_STOP> stops, D2D1_GAMMA gamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP) => CreateGradientStopCollection(context?.Object!, stops, gamma, extendMode);
    public static IComObject<ID2D1GradientStopCollection> CreateGradientStopCollection(this ID2D1RenderTarget context, IEnumerable<D2D1_GRADIENT_STOP> stops, D2D1_GAMMA gamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(stops);
        var finalStops = stops.ToArray();
        if (finalStops.Length == 0)
            throw new ArgumentException(null, nameof(stops));

        context.CreateGradientStopCollection(finalStops, finalStops.Length(), gamma, extendMode, out var stps).ThrowOnError();
        return new ComObject<ID2D1GradientStopCollection>(stps);
    }

    public static void WithTextAntialiasMode(this IComObject<ID2D1RenderTarget> context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action) => WithTextAntialiasMode(context?.Object!, mode, action);
    public static void WithTextAntialiasMode(this ID2D1RenderTarget context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action)
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

    public static void WithAntialiasMode(this IComObject<ID2D1RenderTarget> context, D2D1_ANTIALIAS_MODE mode, Action action) => WithAntialiasMode(context?.Object!, mode, action);
    public static void WithAntialiasMode(this ID2D1RenderTarget context, D2D1_ANTIALIAS_MODE mode, Action action)
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

    public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1RenderTarget> context) => GetPixelSize(context?.Object!);
    public static D2D_SIZE_U GetPixelSize(this ID2D1RenderTarget context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetPixelSize();
    }

    public static D2D_SIZE_F GetSize(this IComObject<ID2D1RenderTarget> context) => GetSize(context?.Object!);
    public static D2D_SIZE_F GetSize(this ID2D1RenderTarget context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetSize();
    }

    public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1RenderTarget> context) => GetPixelFormat(context?.Object!);
    public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1RenderTarget context)
    {
        ArgumentNullException.ThrowIfNull(context);
        return context.GetPixelFormat();
    }

    public static void SetTags(this IComObject<ID2D1RenderTarget> context, ulong tag1, ulong tag2 = 0) => SetTags(context?.Object!, tag1, tag2);
    public static void SetTags(this ID2D1RenderTarget context, ulong tag1, ulong tag2 = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.SetTags(tag1, tag2);
    }

    // this one is useless but is consistent with EndDraw
    public static void BeginDraw(this IComObject<ID2D1RenderTarget> device) => BeginDraw(device?.Object!);
    public static void BeginDraw(this ID2D1RenderTarget device) => device?.BeginDraw();
    public static void EndDraw(this IComObject<ID2D1RenderTarget> device) => EndDraw(device?.Object!);
    public static void EndDraw(this ID2D1RenderTarget device) => device?.EndDraw(0, 0).ThrowOnError();
    public static void Clear(this IComObject<ID2D1RenderTarget> device, D3DCOLORVALUE? clearColor = null) => Clear(device?.Object!, clearColor);
    public static void Clear(this ID2D1RenderTarget device, D3DCOLORVALUE? clearColor = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.Clear(clearColor.CopyToPointer());
    }

    public static void DrawText(this IComObject<ID2D1RenderTarget> device,
        string? text,
        IComObject<IDWriteTextFormat> format,
        D2D_RECT_F rect,
        IComObject<ID2D1Brush> brush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(device?.Object!, text, format?.Object!, rect, brush?.Object!, options, measuringMode);

    public static void DrawText(this ID2D1RenderTarget device,
        string? text,
        IDWriteTextFormat format,
        D2D_RECT_F rect,
        ID2D1Brush brush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(format);
        if (text == null)
            return;

        using var p = new Pwstr(text);
        device.DrawText(p, (uint)text.Length, format, rect, brush, options, measuringMode);
    }

    [SupportedOSPlatform("windows8.0")]
    public static void DrawBitmap(this IComObject<ID2D1RenderTarget> device,
        IComObject<ID2D1Bitmap1> bitmap,
        float opacity,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object!, bitmap?.Object!, opacity, interpolationMode, destinationRectangle, sourceRectangle);

    public static void DrawBitmap(this IComObject<ID2D1RenderTarget> device,
        IComObject<ID2D1Bitmap> bitmap,
        float opacity,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object!, bitmap?.Object!, opacity, interpolationMode, destinationRectangle, sourceRectangle);

    public static void DrawBitmap(this ID2D1RenderTarget device,
        ID2D1Bitmap bitmap,
        float opacity,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
        D2D_RECT_F? destinationRectangle = null,
        D2D_RECT_F? sourceRectangle = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.DrawBitmap(bitmap, destinationRectangle.CopyToPointer(), opacity, interpolationMode, sourceRectangle.CopyToPointer());
    }

    public static void DrawTextLayout(this IComObject<ID2D1RenderTarget> context,
        D2D_POINT_2F origin,
        IComObject<IDWriteTextLayout> layout,
        IComObject<ID2D1Brush>? defaultFillBrush = null,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => DrawTextLayout(context?.Object!, origin, layout?.Object!, defaultFillBrush?.Object!, options);

    public static void DrawTextLayout(this ID2D1RenderTarget context,
        D2D_POINT_2F origin,
        IDWriteTextLayout layout,
        ID2D1Brush? defaultFillBrush = null,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(layout);
        context.DrawTextLayout(origin, layout, defaultFillBrush!, options);
    }

    public static void FillGeometry(this IComObject<ID2D1RenderTarget> context, IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Brush> brush, IComObject<ID2D1Brush>? opacityBrush = null) => FillGeometry(context?.Object!, geometry?.Object!, brush?.Object!, opacityBrush?.Object!);
    public static void FillGeometry(this ID2D1RenderTarget context, ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush? opacityBrush = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillGeometry(geometry, brush, opacityBrush);
    }

    public static void DrawLine(this IComObject<ID2D1RenderTarget> context, D2D_POINT_2F point0, D2D_POINT_2F point1, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawLine(context?.Object!, point0, point1, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawLine(this ID2D1RenderTarget context, D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawLine(point0, point1, brush, strokeWidth, strokeStyle);
    }

    public static void DrawRoundedRectangle(this IComObject<ID2D1RenderTarget> context, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawRoundedRectangle(context?.Object!, roundedRect, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawRoundedRectangle(this ID2D1RenderTarget context, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawRoundedRectangle(roundedRect, brush, strokeWidth, strokeStyle);
    }

    public static void FillRoundedRectangle(this IComObject<ID2D1RenderTarget> context, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush) => FillRoundedRectangle(context?.Object!, roundedRect, brush?.Object!);
    public static void FillRoundedRectangle(this ID2D1RenderTarget context, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillRoundedRectangle(roundedRect, brush);
    }

    public static void DrawRectangle(this IComObject<ID2D1RenderTarget> context, D2D_RECT_F rect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawRectangle(context?.Object!, rect, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawRectangle(this ID2D1RenderTarget context, D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawRectangle(rect, brush, strokeWidth, strokeStyle);
    }

    public static void FillRectangle(this IComObject<ID2D1RenderTarget> context, D2D_RECT_F rect, IComObject<ID2D1Brush> brush) => FillRectangle(context?.Object!, rect, brush?.Object!);
    public static void FillRectangle(this ID2D1RenderTarget context, D2D_RECT_F rect, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillRectangle(rect, brush);
    }

    public static void DrawEllipse(this IComObject<ID2D1RenderTarget> context, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawEllipse(context?.Object!, ellipse, brush?.Object!, strokeWidth, strokeStyle?.Object!);
    public static void DrawEllipse(this ID2D1RenderTarget context, D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.DrawEllipse(ellipse, brush, strokeWidth, strokeStyle);
    }

    public static void FillEllipse(this IComObject<ID2D1RenderTarget> context, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush) => FillEllipse(context?.Object!, ellipse, brush?.Object!);
    public static void FillEllipse(this ID2D1RenderTarget context, D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(brush);
        context.FillEllipse(ellipse, brush);
    }

    public static void DrawGeometry(this IComObject<ID2D1RenderTarget> renderTarget,
        IComObject<ID2D1Geometry> geometry,
        IComObject<ID2D1Brush> brush,
        float strokeWidth = 1,
        IComObject<ID2D1StrokeStyle>? strokeStyle = null) => DrawGeometry(renderTarget?.Object!, geometry?.Object!, brush?.Object!, strokeWidth, strokeStyle?.Object!);

    public static void DrawGeometry(this ID2D1RenderTarget renderTarget,
        ID2D1Geometry geometry,
        ID2D1Brush brush,
        float strokeWidth = 1,
        ID2D1StrokeStyle? strokeStyle = null)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        ArgumentNullException.ThrowIfNull(brush);
        renderTarget.DrawGeometry(geometry, brush, strokeWidth, strokeStyle);
    }

    public static void PushLayer(this IComObject<ID2D1RenderTarget> context, D2D1_LAYER_PARAMETERS parameters) => PushLayer(context?.Object!, parameters);
    public static void PushLayer(this ID2D1RenderTarget context, D2D1_LAYER_PARAMETERS parameters)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PushLayer(parameters, null);
    }

    public static void PopLayer(this IComObject<ID2D1RenderTarget> context) => PopLayer(context?.Object!);
    public static void PopLayer(this ID2D1RenderTarget context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PopLayer();
    }

    public static void PushAxisAlignedClip(this IComObject<ID2D1RenderTarget> renderTarget, D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE) => PushAxisAlignedClip(renderTarget?.Object!, clipRect, antialiasMode);
    public static void PushAxisAlignedClip(this ID2D1RenderTarget renderTarget, D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        renderTarget.PushAxisAlignedClip(clipRect, antialiasMode);
    }

    public static void PopAxisAlignedClip(this IComObject<ID2D1RenderTarget> renderTarget) => PopAxisAlignedClip(renderTarget?.Object!);
    public static void PopAxisAlignedClip(this ID2D1RenderTarget renderTarget)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        renderTarget.PopAxisAlignedClip();
    }
}