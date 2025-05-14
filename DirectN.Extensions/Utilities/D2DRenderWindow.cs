namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.1")]
public class D2DRenderWindow(
    string? title = null,
    WINDOW_STYLE style = WINDOW_STYLE.WS_POPUP | WINDOW_STYLE.WS_THICKFRAME | WINDOW_STYLE.WS_CAPTION | WINDOW_STYLE.WS_SYSMENU | WINDOW_STYLE.WS_MAXIMIZEBOX | WINDOW_STYLE.WS_MINIMIZEBOX,
    WINDOW_EX_STYLE extendedStyle = 0,
    RECT? rect = null,
    HWND? parentHandle = null,
    HMENU? menu = null,
    string? className = null)
    : Window(title, style, extendedStyle, rect, parentHandle, menu, className), IWithProperties, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event EventHandler<HandledEventArgs>? Rendering;
    public event EventHandler? Rendered;

    protected virtual D2D1_FACTORY_TYPE FactoryType => D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED;
#if DEBUG
    protected virtual D2D1_FACTORY_OPTIONS? FactoryOptions => new D2D1_FACTORY_OPTIONS { debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_INFORMATION };
#else
    protected virtual D2D1_FACTORY_OPTIONS? FactoryOptions => null;
#endif
    protected IComObject<ID2D1HwndRenderTarget>? RenderTarget { get; set; }
    public virtual D3DCOLORVALUE BackgroundColor { get => this.GetProperty<D3DCOLORVALUE>(nameof(BackgroundColor)); set => this.SetProperty(nameof(BackgroundColor), value); }

    private readonly ConcurrentDictionary<string, object?> _properties = [];
    ConcurrentDictionary<string, object?> IWithProperties.Properties => _properties;
    void IWithProperties.OnPropertyChanged(string propertyName) => OnPropertyChanged(propertyName);

    // we handle background
    protected override void RegisterClass(string className, nint windowProc, Icon? icon = null) => RegisterWindowClass(className, windowProc, icon: icon, background: new HBRUSH());
    protected override bool OnPaint(HDC hdc, PAINTSTRUCT ps) => RenderCore();
    protected override void OnCreated(object? sender, EventArgs e)
    {
        CreateRenderTarget();
        base.OnCreated(sender, e);
    }

    [MemberNotNull(nameof(RenderTarget))]
    protected virtual void CreateRenderTarget()
    {
        var rt = RenderTarget;
        RenderTarget = null;
        rt?.Dispose();
        using var factory = D2D1Functions.D2D1CreateFactory(FactoryType, FactoryOptions);
        RenderTarget = factory.CreateHwndRenderTarget(new D2D1_HWND_RENDER_TARGET_PROPERTIES { hwnd = Handle, pixelSize = ClientRect.Size.ToD2D_SIZE_U() });
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        RenderTarget?.Resize(ClientRect.Size.ToD2D_SIZE_U());
        return true;
    }

    protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        switch (msg)
        {
            case MessageDecoder.WM_ERASEBKGND:
                return new LRESULT { Value = 1 }; // we handle background
        }
        return base.WindowProc(hwnd, msg, wParam, lParam);
    }

    protected override void Dispose(bool disposing)
    {
        RenderTarget?.Dispose();
        base.Dispose(disposing);
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        OnPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        Invalidate(null, false);
    }

    protected virtual void OnPropertyChanged(object? sender, PropertyChangedEventArgs e) => PropertyChanged?.Invoke(sender, e);
    protected virtual void OnRendering(object? sender, HandledEventArgs e) => Rendering?.Invoke(sender, e);
    protected virtual void OnRendered(object? sender, EventArgs e) => Rendered?.Invoke(sender, e);
    protected virtual bool RenderCore()
    {
        var e = new HandledEventArgs();
        OnRendering(this, e);
        if (e.Handled)
            return true;

        var rt = RenderTarget;
        if (rt == null)
            return false;

        rt.BeginDraw();
        Render(rt);
        rt.EndDraw();
        OnRendered(this, EventArgs.Empty);
        return true;
    }

    protected virtual void Render(IComObject<ID2D1HwndRenderTarget> renderTarget)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);
        renderTarget.Clear(BackgroundColor);
    }
}
