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

        DoUseDirect2D = UseDirect2D;
        if (DoUseDirect2D)
        {
            DeviceCreateFlags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT; // need Direct2D support
        }

        CompositorController = new CompositorController();
        CompositorController.CommitNeeded += (s, e) => s.Commit();

        var desktopInterop = CompositorController.Compositor.As<ICompositorDesktopInterop>();
        desktopInterop.CreateDesktopWindowTarget(Handle, TopMostDesktopWindowTarget, out var target).ThrowOnError();
        var compositionTarget = MarshalInspectable<CompositionTarget>.FromAbi(target);

        RootVisual = CreateWindowVisual();
        compositionTarget.Root = RootVisual;
        SetVisualSize();
    }

    public CompositionGraphicsDevice? GraphicsDevice { get; private set; } // guaranteed to be not null after device resources are created
    public IComObject<ID2D1Device>? D2D1Device { get; private set; } // guaranteed to be not null if UseDirect2D is set to true, and after device resources are created

    public CompositorController CompositorController { get; }
    public SpriteVisual RootVisual { get; }
    public Compositor Compositor => CompositorController.Compositor;

    protected bool DoUseDirect2D { get; }
    protected virtual bool TopMostDesktopWindowTarget => true;
    protected virtual bool UseDirect2D => true;
    protected virtual SpriteVisual CreateWindowVisual() => Compositor.CreateSpriteVisual();

    protected override void CreateDeviceResources()
    {
        base.CreateDeviceResources();

        object? device;
        if (DoUseDirect2D)
        {
            // we need to create a D2D device for the composition graphics device to be able to use ICompositionDrawingSurfaceInterop.BeginDraw
            using var fac = D2D1Functions.D2D1CreateFactory1();
            D2D1Device = fac.CreateDevice(Device.As<IDXGIDevice>()!);
            device = D2D1Device.Object;
        }
        else
        {
            device = Device;
        }
        if (device == null)
            return;

        var interop = CompositorController.Compositor.As<ICompositorInterop>();
        ComObject.WithComInstance(D2D1Device, unk =>
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
            D2D1Device?.Dispose();
        }
        base.Dispose(disposing);
    }
}
