namespace DirectN.Utilities;

[SupportedOSPlatform("windows8.1")]
public class D3D11SwapChainWindow(
    string? title = null,
    WINDOW_STYLE style = WINDOW_STYLE.WS_POPUP | WINDOW_STYLE.WS_THICKFRAME | WINDOW_STYLE.WS_CAPTION | WINDOW_STYLE.WS_SYSMENU | WINDOW_STYLE.WS_MAXIMIZEBOX | WINDOW_STYLE.WS_MINIMIZEBOX,
    WINDOW_EX_STYLE extendedStyle = 0,
    RECT? rect = null,
    HWND? parentHandle = null,
    HMENU? menu = null,
    string? className = null)
    : Window(title, style, extendedStyle, rect, parentHandle, menu, className)
{
    public event EventHandler<HandledEventArgs>? Rendering;
    public event EventHandler? Rendered;

    private IComObject<ID3D11Device>? _device;
    private IComObject<ID3D11DeviceContext>? _deviceContext;
    private IComObject<IDXGISwapChain1>? _swapChain;
    private readonly VerticalBlankTicker _ticker = new();

    protected VerticalBlankTicker Ticker => _ticker;
    protected virtual bool MultithreadProtected { get; set; } = true;
    protected virtual D3D11_CREATE_DEVICE_FLAG DeviceCreateFlags { get; set; }
    protected virtual IComObject<ID3D11Device>? Device => _device;
    protected virtual IComObject<ID3D11DeviceContext>? DeviceContext => _deviceContext;
    protected virtual IComObject<IDXGISwapChain1>? SwapChain => _swapChain;

    // we handle background
    protected override void RegisterClass(string className, nint windowProc, Icon? icon = null) => RegisterWindowClass(className, windowProc, icon: icon, background: new HBRUSH());
    protected override bool OnPaint(HDC hdc, PAINTSTRUCT ps) => RenderCore();
    protected override void OnCreated(object? sender, EventArgs e)
    {
        CreateDeviceResources();
        _ticker.Tick += (s, e) => Invalidate();
        _ticker.Start();
        base.OnCreated(sender, e);
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        var device = Device;
        var swapChain = SwapChain;
        if (device != null && swapChain != null)
        {
            if (!size.IsEmpty)
            {
                DisposeSwapChainDependentResources();
                //swapChain.ResizeBuffers(0, 0, 0, DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, 0);
                swapChain.ResizeBuffers(0, (uint)size.cx, (uint)size.cy, DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, 0);
                CreateSwapChainDependentResources(device, swapChain);
            }
        }
        base.OnResized(type, size);
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
        _ticker?.Stop(1000);
        DisposeDeviceResources();
        base.Dispose(disposing);
    }

    protected virtual void CreateDeviceResources()
    {
        DisposeDeviceResources();

        var deviceFlags = DeviceCreateFlags;

#if DEBUG
        // note: to see debug messages in Visual Studio, enable native debugging in .NET project
        deviceFlags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;
#endif

        if (!DXGIFunctions.IsDebugLayerAvailable && deviceFlags.HasFlag(D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG))
        {
            deviceFlags &= ~D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;
            Application.TraceWarning("Debug layer was unset, final flags:" + deviceFlags);
        }

        _device = D3D11Functions.D3D11CreateDevice(null!, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, deviceFlags, out _deviceContext);
        if (MultithreadProtected)
        {
            var mt = _device.As<ID3D11Multithread>();
            mt?.Object.SetMultithreadProtected(true);
        }

        var desc = new DXGI_SWAP_CHAIN_DESC1
        {
            Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM,
            BufferUsage = DXGI_USAGE.DXGI_USAGE_RENDER_TARGET_OUTPUT,
            BufferCount = 2,
            SampleDesc = new DXGI_SAMPLE_DESC { Count = 1 },
            SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_DISCARD,
            Scaling = DXGI_SCALING.DXGI_SCALING_STRETCH,
        };

        var size = ClientRect.Size;
        if (size.IsEmpty)
        {
            desc.Width = Math.Max(8, (uint)size.cx);
            desc.Height = Math.Max(8, (uint)size.cy);
        }

        using var dxgiDevice = _device.As<IDXGIDevice>()!;
        using var adapter = dxgiDevice.GetAdapter();
        using var fac = adapter.GetFactory2()!;

        _swapChain = fac.CreateSwapChainForHwnd<IDXGISwapChain1>(_device, Handle, desc);

        // provide non null references
        CreateSwapChainDependentResources(_device, _swapChain);
        CreateDeviceDependentResources(_device, _swapChain);
    }

    protected virtual void DisposeDeviceResources()
    {
        DisposeDeviceDependentResources();
        DisposeSwapChainDependentResources();

        var dc = Interlocked.Exchange(ref _deviceContext, null);
        if (dc != null)
        {
            dc.ClearState();
            dc.Flush();
            dc.Dispose();
        };

        var sc = Interlocked.Exchange(ref _swapChain, null);
        if (sc != null)
        {
            sc.SetFullscreenState(false);
            sc.Dispose();
        }

        Interlocked.Exchange(ref _device, null)?.Dispose();
    }

    protected virtual void OnRendering(object? sender, HandledEventArgs e) => Rendering?.Invoke(sender, e);
    protected virtual void OnRendered(object? sender, EventArgs e) => Rendered?.Invoke(sender, e);
    protected virtual bool RenderCore()
    {
        var e = new HandledEventArgs();
        OnRendering(this, e);
        if (e.Handled)
            return true;

        var deviceContext = DeviceContext;
        var swapChain = SwapChain;
        if (deviceContext != null && swapChain != null)
        {
            Render(deviceContext, swapChain);
        }
        OnRendered(this, EventArgs.Empty);
        return true;
    }

    protected virtual void CreateDeviceDependentResources(IComObject<ID3D11Device> device, IComObject<IDXGISwapChain1> swapChain)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(swapChain);
    }

    protected virtual void DisposeDeviceDependentResources()
    {
    }

    protected virtual void CreateSwapChainDependentResources(IComObject<ID3D11Device> device, IComObject<IDXGISwapChain1> swapChain)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(swapChain);
    }

    protected virtual void DisposeSwapChainDependentResources()
    {
    }

    protected virtual void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
    {
        ArgumentNullException.ThrowIfNull(deviceContext);
        ArgumentNullException.ThrowIfNull(swapChain);
    }
}
