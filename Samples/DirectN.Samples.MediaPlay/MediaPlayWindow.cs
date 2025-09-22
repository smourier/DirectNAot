namespace DirectN.Samples.MediaPlay;

public class MediaPlayWindow : Window
{
    private Font? _font;
    private PlayerWindow? _playerWindow;
    private const int _buttonsHeight = 24;
    private const int _buttonsPadding = 10;
    private const int _buttonsWidth = 100;
    private const string _title = "DirectN Media Player";

    public MediaPlayWindow()
        : base(_title)
    {
        // we need another (child) window for media playback
        // as DirectX eats everything in a window and we wouldn't be able to see the buttons
        _playerWindow = new PlayerWindow(this);

        // add buttons to the window
        CreateButton("Open", _buttonsPadding, _buttonsPadding, _buttonsWidth, _buttonsHeight, (int)ButtonId.Open);

        // set standard font for all buttons
        _font = GetMessageBoxFont();
        foreach (var win in AllChildWindows)
        {
            _font?.Set(win.Handle);
        }
    }

    private async Task OpenFile()
    {
        var picker = new FileOpenPicker();
        picker.FileTypeFilter.AddRange(VideoFileExtensions);

        InitializeWithWindow.Initialize(picker, Handle);
        var file = await picker.PickSingleFileAsync();
        if (file != null && _playerWindow?.Player != null)
        {
            var source = MediaSource.CreateFromStorageFile(file);
            _playerWindow.Player.Source = source;
            _playerWindow.Player.Play();
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
            _playerWindow?.ResizeAndMove(0, offset, size.cx, size.cy - offset);
        }
        return base.OnResized(type, size);
    }

    protected override DiagnosticsInformation CreateDiagnosticsInformation() => new(Assembly.GetExecutingAssembly(), this, ", ");
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        Interlocked.Exchange(ref _font, null)?.Dispose();
    }

    private enum ButtonId
    {
        Open = 1,
    }

    public static IReadOnlyList<string> VideoFileExtensions => _videoFileExtensions.Value;

    private static readonly Lazy<List<string>> _videoFileExtensions = new(GetVideoFileExtensions);
    private static List<string> GetVideoFileExtensions()
    {
        var list = new List<string>();
        foreach (var ext in Registry.ClassesRoot.GetSubKeyNames())
        {
            if (!ext.StartsWith('.'))
                continue;

            using var key = Registry.ClassesRoot.OpenSubKey(ext);
            var contentType = key?.GetValue("Content Type") as string;
            if (!string.IsNullOrWhiteSpace(contentType) && contentType.StartsWith("video/", StringComparison.OrdinalIgnoreCase))
            {
                list.Add(ext);
            }
        }

        list.Sort(StringComparer.OrdinalIgnoreCase);
        return list;
    }

    private sealed class PlayerWindow(MediaPlayWindow parent)
        : CompositionWindow(null, WINDOW_STYLE.WS_VISIBLE | WINDOW_STYLE.WS_CHILD, parentHandle: parent.Handle)
    {
        private MediaPlayer? _player = new();
        private MediaPlayerSurface? _surface;

        public MediaPlayer? Player => _player;

        protected override void CreateDeviceResources()
        {
            base.CreateDeviceResources();
            _surface = _player!.GetSurface(Compositor);
            var brush = Compositor.CreateSurfaceBrush(_surface.CompositionSurface);
            RootVisual.Brush = brush;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            Interlocked.Exchange(ref _surface, null)?.Dispose();
            Interlocked.Exchange(ref _player, null)?.Dispose();
        }
    }
}
