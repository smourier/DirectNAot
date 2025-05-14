namespace DirectN.Samples.PdfView;

public class PdfViewWindow : CompositionWindow
{
    private Font? _font;
    private ComObject<IPdfRendererNative>? _pdfRendererNative;
    private IComObject<ID2D1DeviceContext>? _deviceContext;
    private IComObject<ID2D1Device>? _device;
    private PdfDocument? _pdfDocument;
    private PdfPage? _pdfPage;

    public PdfViewWindow()
        : base("DirectN Pdf View")
    {
        // add buttons to the window
        var width = 100; var height = 24; var pad = 10;
        CreateButton("Open", pad, pad, width, height, (int)ButtonId.Open);
        CreateButton("Next Page", pad + (width + pad), pad, width, height, (int)ButtonId.Next);
        CreateButton("Previous Page", pad + (width + pad) * 2, pad, width, height, (int)ButtonId.Previous);

        // set nice font for all buttons
        _font = GetMessageBoxFont();
        foreach (var win in AllChildWindows)
        {
            _font?.Set(win.Handle);
        }

        // need Direct2D support
        //DeviceCreateFlags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT;
    }

    protected override void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
    {
        Application.TraceInfo("render");
        //RootVisual.Brush = Compositor.CreateColorBrush(D3DCOLORVALUE.Blue.ToColor());

        //var surface = GraphicsDevice.CreateDrawingSurface(cs.ToSize(), DirectXPixelFormat.B8G8R8A8UIntNormalized, DirectXAlphaMode.Premultiplied);
        //var interop = surface.AsComObject<ICompositionDrawingSurfaceInterop>();
        //using (var dc = interop.BeginDraw())
        //{
        //    var rc = cr.ToD2D_RECT_F();
        //    RenderContext.WithRenderContext(dc, context =>
        //    {
        //        // depending on context, this can be removed
        //        dc.Clear(D3DCOLORVALUE.Transparent);

        //        if (fs > 0)
        //        {
        //            dc.Object.DrawRectangle(rc, context.CreateSolidColorBrush(FrameColor).Object, fs * 2, null);
        //        }
        //    });
        //    interop.EndDraw();
        //}
    }

    private async Task OpenFile()
    {
        var picker = new FileOpenPicker();
        picker.FileTypeFilter.Add(".pdf");

        InitializeWithWindow.Initialize(picker, Handle);
        var file = await picker.PickSingleFileAsync();
        if (file != null)
        {
            _pdfDocument = await PdfDocument.LoadFromFileAsync(file);
            _pdfPage = null;
            if (_pdfDocument.IsPasswordProtected)
            {
                // this is not currently handled
                MessageBox.Show(Handle, "The PDF file is password protected.", "Error", MESSAGEBOX_STYLE.MB_OK | MESSAGEBOX_STYLE.MB_ICONERROR);
                return;
            }

            if (_pdfDocument.PageCount == 0)
            {
                MessageBox.Show(Handle, "The PDF file has no page to display.", "Error", MESSAGEBOX_STYLE.MB_OK | MESSAGEBOX_STYLE.MB_ICONERROR);
                return;
            }

            _pdfPage = _pdfDocument.GetPage(0);
            Invalidate();
        }
    }

    //protected override void CreateDeviceResources()
    //{
    //    base.CreateDeviceResources();

    //    using var device = Device.As<IDXGIDevice>()!;
    //    Functions.PdfCreateRenderer(device.Object, out var obj).ThrowOnError();
    //    _pdfRendererNative = new ComObject<IPdfRendererNative>(obj);

    //    using var factory = D2D1Functions.D2D1CreateFactory1();
    //    _device = factory.CreateDevice(device);
    //    _deviceContext = _device.CreateDeviceContext();

    //    var surface = _deviceContext.CreateBitmapFromDxgiSurface(
    //        SwapChain!.GetBuffer<IDXGISurface>(0),
    //        new D2D1_BITMAP_PROPERTIES1
    //        {
    //            bitmapOptions = D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_TARGET | D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_CANNOT_DRAW,
    //            pixelFormat = new D2D1_PIXEL_FORMAT { format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, alphaMode = D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_IGNORE },
    //        });

    //    _deviceContext.SetTarget(surface);
    //}

    //protected unsafe override void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
    //{
    //    if (_deviceContext != null)
    //    {
    //        if (_pdfPage != null && _pdfRendererNative != null)
    //        {
    //            Application.TraceInfo("render");
    //            var pageUnk = ((IWinRTObject)_pdfPage).NativeObject.ThisPtr; // no AddRef needed
    //            var width = _pdfPage.Size.Width;
    //            var height = _pdfPage.Size.Height;
    //            var renderParams = new PDF_RENDER_PARAMS
    //            {
    //                BackgroundColor = D3DCOLORVALUE.White,
    //                DestinationWidth = (uint)width / 2,
    //                DestinationHeight = (uint)height / 2,
    //                IgnoreHighContrast = false,
    //            };

    //            _deviceContext.BeginDraw();
    //            _pdfRendererNative.Object.RenderPageToDeviceContext(pageUnk, _deviceContext.Object, (nint)(&renderParams)).ThrowOnError();
    //            _deviceContext.EndDraw();
    //            SwapChain!.Present(1, 0);
    //        }
    //    }
    //}

    protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        // handle buttons clicks
        if (msg == MessageDecoder.WM_COMMAND)
        {
            var id = wParam.Value.LOWORD();
            switch ((ButtonId)id)
            {
                case ButtonId.Open:
                    _ = OpenFile();
                    break;

                case ButtonId.Next:
                    movePage(1);
                    break;

                case ButtonId.Previous:
                    movePage(-1);
                    break;
            }

            void movePage(int delta)
            {
                if (_pdfPage == null || _pdfDocument == null)
                    return;

                var page = _pdfPage.Index + delta;
                if (page < 0 || page >= _pdfDocument.PageCount)
                    return;

                if (page == _pdfPage.Index)
                    return;

                _pdfPage.Dispose();
                _pdfPage = _pdfDocument.GetPage((uint)page);
                Invalidate();
            }
            return 0; // handled
        }
        return base.WindowProc(hwnd, msg, wParam, lParam);
    }

    protected override DiagnosticsInformation CreateDiagnosticsInformation() => new(Assembly.GetExecutingAssembly(), this, ", ");
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        Interlocked.Exchange(ref _pdfPage, null)?.Dispose();
        Interlocked.Exchange(ref _font, null)?.Dispose();
        Interlocked.Exchange(ref _pdfRendererNative, null)?.Dispose();
        Interlocked.Exchange(ref _deviceContext, null)?.Dispose();
        Interlocked.Exchange(ref _device, null)?.Dispose();
    }

    private enum ButtonId
    {
        Open = 1,
        Next = 2,
        Previous = 3,
    }
}
