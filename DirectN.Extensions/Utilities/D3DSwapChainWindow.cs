﻿namespace DirectN.Utilities;

[SupportedOSPlatform("windows8.1")]
public class D3DSwapChainWindow(
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

    protected virtual bool MultithreadProtected { get; set; } = true;
    protected VerticalBlankTicker Ticker => _ticker;
    protected IComObject<ID3D11Device>? Device => _device;
    protected IComObject<ID3D11DeviceContext>? DeviceContext => _deviceContext;
    protected IComObject<IDXGISwapChain1>? SwapChain => _swapChain;

    // we handle background
    protected override void RegisterClass(string className, nint windowProc, Icon? icon = null) => RegisterWindowClass(className, windowProc, icon: icon, background: new HBRUSH());
    protected override bool OnPaint(HDC hdc, PAINTSTRUCT ps) => RenderCore();
    protected override void OnHandleCreated(object? sender, EventArgs e)
    {
        CreateDeviceResources();
        _ticker.Tick += (s, e) => Invalidate();
        _ticker.Start();
        base.OnHandleCreated(sender, e);
    }

    protected override bool OnResized()
    {
        var device = Device;
        var swapChain = SwapChain;
        if (device != null && swapChain != null)
        {
            var size = ClientRect.Size;
            if (!size.IsEmpty)
            {
                DeviceContext?.Object.ClearState();
                DisposeDeviceDependentResources();
                swapChain.ResizeBuffers(0, (uint)size.cx, (uint)size.cy, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, 0);
                CreateDeviceDependentResources(device, swapChain);
            }
        }
        OnResized(this, EventArgs.Empty);
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
        DisposeDeviceDependentResources();
        DisposeDeviceResources();
        base.Dispose(disposing);
    }

    protected virtual void CreateDeviceResources()
    {
        DisposeDeviceDependentResources();
        DisposeDeviceResources();

        var dxgiFlags = (DXGI_CREATE_FACTORY_FLAGS)0;
        var deviceFlags = (D3D11_CREATE_DEVICE_FLAG)0;
#if DEBUG
        dxgiFlags |= DXGI_CREATE_FACTORY_FLAGS.DXGI_CREATE_FACTORY_DEBUG;
        deviceFlags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;
#endif

        using var fac = DXGIFunctions.CreateDXGIFactory2(dxgiFlags);
        _device = D3D11Functions.D3D11CreateDevice(null!, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, deviceFlags, out _deviceContext);
        if (MultithreadProtected)
        {
            var mt = _device.As<ID3D11Multithread>();
            mt?.Object.SetMultithreadProtected(true);
        }

        var size = ClientRect.Size;
        var desc = new DXGI_SWAP_CHAIN_DESC1
        {
            Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM,
            BufferUsage = DXGI_USAGE.DXGI_USAGE_RENDER_TARGET_OUTPUT,
            BufferCount = 2,
            SampleDesc = new DXGI_SAMPLE_DESC { Count = 1 },
            SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL,
            Width = Math.Max(8, (uint)size.cx),
            Height = Math.Max(8, (uint)size.cy),
        };

        _swapChain = fac.CreateSwapChainForHwnd<IDXGISwapChain1>(_device, Handle, desc);
        CreateDeviceDependentResources(_device, _swapChain);
    }

    protected virtual void DisposeDeviceResources()
    {
        Interlocked.Exchange(ref _swapChain, null)?.Dispose();
        var dc = Interlocked.Exchange(ref _deviceContext, null);
        if (dc != null)
        {
            dc.Object.ClearState();
            dc.Dispose();
        };
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

    protected virtual void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
    {
        ArgumentNullException.ThrowIfNull(deviceContext);
        ArgumentNullException.ThrowIfNull(swapChain);
    }
}