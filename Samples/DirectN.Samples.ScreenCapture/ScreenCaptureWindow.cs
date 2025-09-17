namespace DirectN.Samples.ScreenCapture;

public class ScreenCaptureWindow : CompositionWindow
{
    private IDirect3DDevice? _direct3DDevice;
    private Direct3D11CaptureFramePool? _captureFramePool;
    private GraphicsCaptureItem? _captureItem;
    private GraphicsCaptureSession? _captureSession;
    private volatile bool _isDisposed;

    public ScreenCaptureWindow()
        : base("DirectN Screen Capture Sample")
    {
        if (!GraphicsCaptureSession.IsSupported())
            throw new NotSupportedException("Graphics capture is not supported on this system.");
    }

    protected override void CreateDeviceResources()
    {
        base.CreateDeviceResources();

        // find primary monitor
        var mon = DirectN.Extensions.Utilities.Monitor.Primary ??
            DirectN.Extensions.Utilities.Monitor.All.FirstOrDefault() ??
            throw new InvalidOperationException("No primary monitor found."); // huh?

        _captureItem = GraphicsCaptureItem.TryCreateFromDisplayId(new DisplayId((ulong)mon.Handle.Value));
        if (_captureItem == null)
            throw new InvalidOperationException("Graphics capture could not be initialized.");

        // create a surface to draw into, same size as captured item
        var size = _captureItem.Size;
        RootVisual.Size = new Vector2(size.Width, size.Height);
        var surface = GraphicsDevice!.CreateDrawingSurface2(size, DirectXPixelFormat.B8G8R8A8UIntNormalized, DirectXAlphaMode.Unspecified);
        RootVisual.Brush = Compositor.CreateSurfaceBrush(surface);

        Functions.CreateDirect3D11DeviceFromDXGIDevice(Device.As<IDXGIDevice>()?.Object!, out var obj).ThrowOnError();
        using var inspectable = new ComObject<IInspectable>(obj);
        ComObject.WithComInstance(inspectable, unk =>
        {
            _direct3DDevice = MarshalInspectable<IDirect3DDevice>.FromAbi(unk);
        });

        _captureFramePool = Direct3D11CaptureFramePool.Create(_direct3DDevice, DirectXPixelFormat.B8G8R8A8UIntNormalized, 2, _captureItem.Size);
        _captureSession = _captureFramePool.CreateCaptureSession(_captureItem);
        _captureSession.IsBorderRequired = false;
        _captureFramePool.FrameArrived += (s, e) =>
        {
            using var frame = s.TryGetNextFrame();
            ProcessFrame(frame);
        };

        _captureSession.StartCapture();
    }

    protected virtual void ProcessFrame(Direct3D11CaptureFrame? frame)
    {
        if (frame == null)
            return;

        var surface = frame.Surface.AsDxgiComObject<IDXGISurface>()!;
        var brush = (CompositionSurfaceBrush)RootVisual?.Brush!;
        using var interop = brush.Surface.AsComObject<ICompositionDrawingSurfaceInterop>();
        using var dc = interop.BeginDraw<ID2D1DeviceContext>();
        try
        {
            using var bmp = dc.CreateBitmapFromDxgiSurface(surface);
            dc.DrawBitmap(bmp, interpolationMode: D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC, destinationRectangle: ClientRect);
        }
        finally
        {
            interop.EndDraw();
        }
    }

    protected override void SetVisualSize()
    {
        // don't call base, we don't want to resize the visual to the window size,
        // just keep it the same size as the capture item (screen size)
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && !Interlocked.Exchange(ref _isDisposed, true))
        {
            _captureSession?.Dispose();
            _captureFramePool?.Dispose();
            _direct3DDevice?.Dispose();
            if (RootVisual != null && RootVisual.Brush != null)
            {
                if (RootVisual.Brush is CompositionSurfaceBrush brush && brush.Surface is CompositionObject co)
                {
                    co.Dispose();
                }
                RootVisual.Brush.Dispose();
            }
        }
        base.Dispose(disposing);
    }
}
