namespace DirectN;

public static partial class Functions
{
    [SupportedOSPlatform("windows6.1")]
    private static readonly Lazy<D2D_SIZE_F> _dpi = new(GetDesktopDpi, true);

    [SupportedOSPlatform("windows6.1")]
    public static D2D_SIZE_F Dpi => _dpi.Value;

    [SupportedOSPlatform("windows6.1")]
    public static D2D_SIZE_F DpiScale => _dpiScale.Value;

    [SupportedOSPlatform("windows6.1")]
    private static readonly Lazy<D2D_SIZE_F> _dpiScale = new(() =>
    {
        var dpi = Dpi;
        return new D2D_SIZE_F(dpi.width / 96, dpi.height / 96);
    }, true);

    // https://docs.microsoft.com/en-us/windows/win32/learnwin32/dpi-and-device-independent-pixels
    [SupportedOSPlatform("windows6.1")]
    public static D2D_SIZE_F GetDesktopDpi()
    {
        D2D1CreateFactory(D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, typeof(ID2D1Factory).GUID, 0, out var obj).ThrowOnError();
        var factory = (ID2D1Factory)obj;
        factory.GetDesktopDpi(out var x, out var y);
        return new D2D_SIZE_F(x, y);
    }

    // https://blogs.msdn.microsoft.com/text/2009/12/11/wpf-text-measurement-units/
    public static float PointsToDips(float pt) => 96 / (72 * pt);
    public static float DipsToPoints(float dip) => 72 / (96 * dip);
    public static float PointsToTwips(float pt) => pt * 20;
    public static float TwipsToPoints(float twips) => twips * 20;

    public static double PixelsToDips(int pixels, double dpi) => pixels * 96 / dpi;
    public static int DipsToPixels(int dips, double dpi) => (int)(dips * dpi / 96);
    public static float PixelsToDips(int pixels, float dpi) => pixels * 96 / dpi;
    public static int DipsToPixels(int dips, float dpi) => (int)(dips * dpi / 96);

    [LibraryImport("kernel32", EntryPoint = "RtlMoveMemory")]
    public static partial void CopyMemory(nint pdst, nint psrc, nint cb);

    [LibraryImport("kernel32", EntryPoint = "RtlZeroMemory")]
    public static partial void ZeroMemory(nint pdst, nint cb);

    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-stgdeserializepropvariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT StgDeserializePropVariant(nint pprop, uint cbMax, out PROPVARIANT ppropvar);

    [LibraryImport("user32")]
    public static partial HRESULT SetWindowCompositionAttribute(HWND hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);

    [LibraryImport("user32")]
    public static partial HRESULT GetWindowCompositionAttribute(HWND hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);
}
