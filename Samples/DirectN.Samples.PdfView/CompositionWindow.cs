namespace DirectN.Samples.PdfView;

public class CompositionWindow : D3D11SwapChainWindow
{
    public CompositionWindow(
        string? title = null,
        WINDOW_STYLE style = WINDOW_STYLE.WS_POPUP | WINDOW_STYLE.WS_THICKFRAME | WINDOW_STYLE.WS_CAPTION | WINDOW_STYLE.WS_SYSMENU | WINDOW_STYLE.WS_MAXIMIZEBOX | WINDOW_STYLE.WS_MINIMIZEBOX,
        WINDOW_EX_STYLE extendedStyle = WINDOW_EX_STYLE.WS_EX_NOREDIRECTIONBITMAP,
        RECT? rect = null,
        HWND? parentHandle = null,
        HMENU? menu = null,
        string? className = null)
        : base(title, style, extendedStyle, rect, parentHandle, menu, className)
    {
        InvalidateOnTick = false; // we're using composition, we don't need to tick
        CompositorController = new CompositorController();
        CompositorController.CommitNeeded += (s, e) => s.Commit();

        var desktopInterop = CompositorController.Compositor.As<ICompositorDesktopInterop>();
        desktopInterop.CreateDesktopWindowTarget(Handle, true, out var target).ThrowOnError();
        var compositionTarget = MarshalInspectable<CompositionTarget>.FromAbi(target);

        RootVisual = CreateWindowVisual();
        compositionTarget.Root = RootVisual;
        SetVisualSize();
    }

    public CompositorController CompositorController { get; }
    [AllowNull]
    public CompositionGraphicsDevice GraphicsDevice { get; private set; }
    public SpriteVisual RootVisual { get; }
    public Compositor Compositor => CompositorController.Compositor;

    protected virtual SpriteVisual CreateWindowVisual() => Compositor.CreateSpriteVisual();

    protected override void CreateDeviceResources()
    {
        base.CreateDeviceResources();
        var interop = CompositorController.Compositor.As<ICompositorInterop>();
        ComObject.WithComInstance(Device, unk =>
        {
            interop.CreateGraphicsDevice(unk, out var obj).ThrowOnError();
            GraphicsDevice = MarshalInterface<CompositionGraphicsDevice>.FromAbi(obj);
        });
    }

    private void SetVisualSize()
    {
        if (RootVisual != null)
        {
            var rc = ClientRect;
            RootVisual.Size = new Vector2(rc.Width, rc.Height);
        }
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        SetVisualSize();
        return base.OnResized(type, size);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            CompositorController?.Dispose();
            RootVisual?.Dispose();
        }
        base.Dispose(disposing);
    }
}
