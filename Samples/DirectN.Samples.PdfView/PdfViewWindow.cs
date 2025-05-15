namespace DirectN.Samples.PdfView;

public class PdfViewWindow : Window
{
    private Font? _font;
    private PdfWindow? _pdfWindow;
    private PdfDocument? _pdfDocument;
    private PdfPage? _pdfPage;
    private string? _fileName;
    private HWND _previousButton;
    private HWND _nextButton;
    private const int _buttonsHeight = 24;
    private const int _buttonsPadding = 10;
    private const int _buttonsWidth = 100;
    private const string _title = "DirectN Pdf View";

    public PdfViewWindow()
        : base(_title)
    {
        // we need another (child) window for rendering PDF
        // as DirectX eats everything in a window and we wouldn't be able to see the buttons
        _pdfWindow = new PdfWindow(this);

        // add buttons to the window
        CreateButton("Open", _buttonsPadding, _buttonsPadding, _buttonsWidth, _buttonsHeight, (int)ButtonId.Open);
        _previousButton = CreateButton("Previous Page", _buttonsPadding + (_buttonsWidth + _buttonsPadding), _buttonsPadding, _buttonsWidth, _buttonsHeight, (int)ButtonId.Previous);
        _nextButton = CreateButton("Next Page", _buttonsPadding + (_buttonsWidth + _buttonsPadding) * 2, _buttonsPadding, _buttonsWidth, _buttonsHeight, (int)ButtonId.Next);

        // set standard font for all buttons
        _font = GetMessageBoxFont();
        foreach (var win in AllChildWindows)
        {
            _font?.Set(win.Handle);
        }

        LoadPage(0);
    }

    private void LoadPage(uint index)
    {
        _pdfPage?.Dispose();
        _pdfPage = _pdfDocument?.GetPage(index);
        _pdfWindow?.Invalidate();
        if (_pdfPage != null)
        {
            Text = $"{_title} - {_fileName} - Page {_pdfPage.Index + 1} / {_pdfDocument!.PageCount}";
            Functions.EnableWindow(_previousButton, _pdfPage.Index > 0);
            Functions.EnableWindow(_nextButton, _pdfPage.Index < _pdfDocument.PageCount - 1);
        }
        else
        {
            Text = _title;
            Functions.EnableWindow(_previousButton, false);
            Functions.EnableWindow(_nextButton, false);
        }
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
            _fileName = file.Path;
            _pdfPage?.Dispose();
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
            LoadPage(0);
        }
    }

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

                LoadPage((uint)page);
            }
            return 0; // handled
        }
        return base.WindowProc(hwnd, msg, wParam, lParam);
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        if (type != WindowResizedType.Minimized)
        {
            // resize pdf window to fit the client area of this window w/o buttons
            var offset = _buttonsHeight + 2 * _buttonsPadding;
            _pdfWindow?.ResizeAndMove(0, offset, size.cx, size.cy - offset);
        }
        return base.OnResized(type, size);
    }

    protected override DiagnosticsInformation CreateDiagnosticsInformation() => new(Assembly.GetExecutingAssembly(), this, ", ");
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        Interlocked.Exchange(ref _pdfWindow, null)?.Dispose();
        Interlocked.Exchange(ref _pdfPage, null)?.Dispose();
        Interlocked.Exchange(ref _font, null)?.Dispose();
    }

    private enum ButtonId
    {
        Open = 1,
        Next = 2,
        Previous = 3,
    }

    private sealed class PdfWindow(PdfViewWindow parent)
        : CompositionWindow(null, WINDOW_STYLE.WS_VISIBLE | WINDOW_STYLE.WS_CHILD, parentHandle: parent.Handle)
    {
        private ComObject<IPdfRendererNative>? _pdfRendererNative;

        protected override void CreateDeviceResources()
        {
            base.CreateDeviceResources();

            using var device = Device.As<IDXGIDevice>()!;
            Functions.PdfCreateRenderer(device.Object, out var obj).ThrowOnError();
            _pdfRendererNative = new ComObject<IPdfRendererNative>(obj);
        }

        private static Size GetScaleFactor(Size availableSize, Size contentSize)
        {
            var scaleX = contentSize.Width == 0 ? 0 : availableSize.Width / contentSize.Width;
            var scaleY = contentSize.Height == 0 ? 0 : availableSize.Height / contentSize.Height;
            var minscale = scaleX < scaleY ? scaleX : scaleY;
            scaleX = scaleY = minscale;
            return new Size(scaleX, scaleY);
        }

        protected unsafe override void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
        {
            if (GraphicsDevice == null)
                return;

            var surface = GraphicsDevice.CreateDrawingSurface(ClientRect.ToSize(), DirectXPixelFormat.B8G8R8A8UIntNormalized, DirectXAlphaMode.Premultiplied);
            RootVisual.Brush = Compositor.CreateSurfaceBrush(surface);
            using var interop = surface.AsComObject<ICompositionDrawingSurfaceInterop>();
            using var dc = interop.BeginDraw(null);
            dc.Clear(D3DCOLORVALUE.LightGray);

            if (parent._pdfPage != null && _pdfRendererNative != null)
            {
                var pageUnk = ((IWinRTObject)parent._pdfPage).NativeObject.ThisPtr; // no AddRef needed

                // resize to fit window's height or width if window's width is too small
                var rc = ClientRect;
                var size = parent._pdfPage.Size;

                var factor = GetScaleFactor(rc.ToSize(), size);
                var width = size.Width * factor.Width;
                var height = size.Height * factor.Height;

                // center if needed
                // there may be an existing transform, so we need to combine it and restore it
                D2D_MATRIX_3X2_F? xf = null;
                if (width < rc.Width || height < rc.Height)
                {
                    xf = dc.GetTransform();
                    dc.SetTransform(xf.Value * D2D_MATRIX_3X2_F.Translation(
                        Math.Max(0, (float)((rc.Width - width) / 2)),
                        Math.Max(0, (float)((rc.Height - height) / 2)))
                        );
                }

                using var backgroundBrush = dc.CreateSolidColorBrush(D3DCOLORVALUE.White);
                // note sure why but PDF_RENDER_PARAMS's BackgroundColor seems to not be used
                dc.FillRectangle(new D2D_RECT_F(0, 0, width, height), backgroundBrush);

                var renderParams = new PDF_RENDER_PARAMS
                {
                    //BackgroundColor = D3DCOLORVALUE.White,
                    DestinationWidth = (uint)width,
                    DestinationHeight = (uint)height,
                };

                // render
                _pdfRendererNative.Object.RenderPageToDeviceContext(pageUnk, dc.Object, (nint)(&renderParams)).ThrowOnError();

                // restore previous transform
                if (xf.HasValue)
                {
                    dc.SetTransform(xf.Value);
                }
            }

            interop.EndDraw();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            Interlocked.Exchange(ref _pdfRendererNative, null)?.Dispose();
        }
    }
}
