namespace DirectN;

public static partial class Functions
{
    private static readonly Lazy<D2D_SIZE_F> _dpi = new(GetDesktopDpi, true);
    public static D2D_SIZE_F Dpi => _dpi.Value;
    public static D2D_SIZE_F DpiScale => _dpiScale.Value;
    private static readonly Lazy<D2D_SIZE_F> _dpiScale = new(() =>
    {
        var dpi = Dpi;
        return new D2D_SIZE_F(dpi.width / 96, dpi.height / 96);
    }, true);

    // https://docs.microsoft.com/en-us/windows/win32/learnwin32/dpi-and-device-independent-pixels
    public static D2D_SIZE_F GetDesktopDpi()
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
        {
            D2D1CreateFactory(D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, typeof(ID2D1Factory).GUID, 0, out var unk);
            if (unk != 0)
            {
                var sw = new StrategyBasedComWrappers();
                if (sw.GetOrCreateObjectForComInstance(unk, CreateObjectFlags.UniqueInstance) is ID2D1Factory factory)
                {
                    factory.GetDesktopDpi(out var x, out var y);
                    ((ComObject)(object)factory).FinalRelease();
                    return new(x, y);
                }
            }
        }
        return new(96, 96);
    }

    // https://blogs.msdn.microsoft.com/text/2009/12/11/wpf-text-measurement-units/
    public static float PointsToDips(float pt) => 96 / (72 * pt);
    public static float DipsToPoints(float dip) => 72 / (96 * dip);
    public static float PointsToTwips(float pt) => pt * 20;
    public static float TwipsToPoints(float twips) => twips / 20;

    public static double PixelsToDips(int pixels, double dpi) => pixels * 96 / dpi;
    public static int DipsToPixels(int dips, double dpi) => (int)(dips * dpi / 96);
    public static float PixelsToDips(int pixels, float dpi) => pixels * 96 / dpi;
    public static int DipsToPixels(int dips, float dpi) => (int)(dips * dpi / 96);

    [LibraryImport("kernel32", EntryPoint = "RtlMoveMemory")]
    [PreserveSig]
    public static partial void CopyMemory(nint pdst, nint psrc, nint cb);

    [LibraryImport("kernel32", EntryPoint = "RtlZeroMemory")]
    [PreserveSig]
    public static partial void ZeroMemory(nint pdst, nint cb);

    [LibraryImport("PROPSYS")]
    [PreserveSig]
    public static partial HRESULT StgDeserializePropVariant(nint pprop, uint cbMax, out PROPVARIANT ppropvar);

    [LibraryImport("user32")]
    [PreserveSig]
    public static partial HRESULT SetWindowCompositionAttribute(HWND hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);

    [LibraryImport("user32")]
    [PreserveSig]
    public static partial HRESULT GetWindowCompositionAttribute(HWND hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);

    [LibraryImport("user32")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsTopLevelWindow(HWND handle);

    [LibraryImport("DWriteCore")]
    [PreserveSig]
    public static partial HRESULT DWriteCoreCreateFactory(DWRITE_FACTORY_TYPE factoryType, in Guid iid, out nint factory);

    [LibraryImport("dxgidebug")]
    [PreserveSig]
    public static partial HRESULT DXGIGetDebugInterface(in Guid riid, out nint ppDebug);

    [SupportedOSPlatform("windows5.0")]
    public static LRESULT SendMessageW(HWND hWnd, uint Msg, WPARAM wParam) => SendMessageW(hWnd, Msg, wParam, LPARAM.Null);

    [SupportedOSPlatform("windows5.0")]
    public static LRESULT SendMessageW(HWND hWnd, uint Msg, LPARAM lParam) => SendMessageW(hWnd, Msg, WPARAM.Null, lParam);

    [SupportedOSPlatform("windows5.0")]
    public static LRESULT SendMessageW(HWND hWnd, uint Msg) => SendMessageW(hWnd, Msg, WPARAM.Null, LPARAM.Null);

    [SupportedOSPlatform("windows5.0")]
    public static BOOL PostMessageW(HWND hWnd, uint Msg, WPARAM wParam) => PostMessageW(hWnd, Msg, wParam, LPARAM.Null);

    [SupportedOSPlatform("windows5.0")]
    public static BOOL PostMessageW(HWND hWnd, uint Msg, LPARAM lParam) => PostMessageW(hWnd, Msg, WPARAM.Null, lParam);

    [SupportedOSPlatform("windows5.0")]
    public static BOOL PostMessageW(HWND hWnd, uint Msg) => PostMessageW(hWnd, Msg, WPARAM.Null, LPARAM.Null);

    [LibraryImport("user32")]
    private static partial nint MB_GetString(int button);

    public static string? GetMessageBoxString(MESSAGEBOX_RESULT button, bool removeMnemonics = true)
    {
        var ptr = MB_GetString((int)(button - 1));
        if (ptr == 0)
            return null;

        var str = Marshal.PtrToStringUni(ptr);
        if (removeMnemonics)
            return str?.Replace("&", string.Empty);

        return str;
    }
}
