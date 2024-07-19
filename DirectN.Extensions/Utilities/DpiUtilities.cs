namespace DirectN.Extensions.Utilities;

// note this class considers dpix = dpiy
public static class DpiUtilities
{
    public const int USER_DEFAULT_SCREEN_DPI = 96;

    public static int TextScaleFactor => _textScaleFactor.Value;
    private static readonly Lazy<int> _textScaleFactor = new(() =>
    {
        try
        {
            // https://stackoverflow.com/questions/64785427/c-windows-api-how-to-retrieve-font-scaling-percentage
            using var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Accessibility", false);
            if (key != null)
            {
                if (Conversions.TryChangeType<int>(key.GetValue("TextScaleFactor"), out var factor) && factor > 0)
                    return factor;
            }
        }
        catch
        {
            // continue
        }
        return 100;
    }, true);

    // you should always use this one and it will fallback if necessary
    // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getdpiforwindow
    public static D2D_SIZE_U GetDpiForWindow(HWND hwnd)
    {
        var module = Functions.LoadLibraryW(PWSTR.From("user32.dll"));
        try
        {
            var proc = Functions.GetProcAddress(module, PSTR.From("GetDpiForWindow")); // Windows 10 1607
            if (proc == 0)
                return GetDpiForNearestMonitor(hwnd);

            var dpi = Marshal.GetDelegateForFunctionPointer<GetDpiForWindowFn>(proc)(hwnd.Value);
            return new D2D_SIZE_U((uint)dpi, (uint)dpi);
        }
        finally
        {
            if (module.Value != 0)
            {
                Functions.FreeLibrary(module);
            }
        }
    }

    public static D2D_SIZE_U GetDpiForNearestMonitor(HWND hwnd) => GetDpiForMonitor(Functions.MonitorFromWindow(hwnd, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST));
    public static D2D_SIZE_U GetDpiForNearestMonitor(int x, int y) => GetDpiForMonitor(Functions.MonitorFromPoint(new POINT(x, y), MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST));
    public static D2D_SIZE_U GetDpiForMonitor(HMONITOR monitor, MONITOR_DPI_TYPE type = MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI)
    {
        if (monitor.Value == 0)
            return new D2D_SIZE_U(USER_DEFAULT_SCREEN_DPI, USER_DEFAULT_SCREEN_DPI);

        var module = Functions.LoadLibraryW(PWSTR.From("shcore.dll"));
        try
        {
            var proc = Functions.GetProcAddress(module, PSTR.From("GetDpiForMonitor")); // Windows 8.1
            if (proc == 0)
                return GetDpiForDesktop();

            int hr;
            uint x;
            uint y;
            unsafe
            {
                hr = Marshal.GetDelegateForFunctionPointer<GetDpiForMonitorFn>(proc)(monitor.Value, type, &x, &y);
            }
            if (hr < 0)
                return GetDpiForDesktop();

            return new D2D_SIZE_U(x, y);
        }
        finally
        {
            if (module.Value != 0)
            {
                Functions.FreeLibrary(module);
            }
        }
    }

    public static D2D_SIZE_F GetDpiForDesktopF() => Functions.GetDesktopDpi();
    public static D2D_SIZE_U GetDpiForDesktop() { var dpi = Functions.GetDesktopDpi(); return new D2D_SIZE_U((uint)dpi.width, (uint)dpi.height); }
    public static uint GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value)
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17134))
            return Functions.GetDpiFromDpiAwarenessContext(value);

        return USER_DEFAULT_SCREEN_DPI;
    }

    public static uint GetWindowDpi(HWND hwnd) => GetDpiFromDpiAwarenessContext(GetWindowDpiAwarenessContext(hwnd));

    public static DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(HWND hwnd)
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 14393))
            return Functions.GetWindowDpiAwarenessContext(hwnd);

        return DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_INVALID;
    }

    public static DPI_AWARENESS_CONTEXT GetDpiAwarenessContextForCurrentProcess() => GetDpiAwarenessContextForProcess(HANDLE.Null);
    public static DPI_AWARENESS_CONTEXT GetDpiAwarenessContextForProcess(HANDLE processHandle)
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17134))
            return Functions.GetDpiAwarenessContextForProcess(processHandle);

        return DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_INVALID;
    }

    public static DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext()
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 14393))
            return Functions.GetThreadDpiAwarenessContext();

        return DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_INVALID;
    }

    public static string GetDpiAwarenessDescription(DPI_AWARENESS_CONTEXT awareness)
    {
        if (awareness.Value == 0)
            return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE);

        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 14393))
        {
            if (Functions.AreDpiAwarenessContextsEqual(awareness, DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE))
                return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE);

            if (Functions.AreDpiAwarenessContextsEqual(awareness, DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE))
                return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE);

            if (Functions.AreDpiAwarenessContextsEqual(awareness, DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE))
                return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE);

            if (Functions.AreDpiAwarenessContextsEqual(awareness, DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2))
                return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2);

            if (Functions.AreDpiAwarenessContextsEqual(awareness, DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED))
                return nameof(DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED);
        }

        if (IntPtr.Size == 4)
            return "0x" + awareness.Value.ToString("X8");

        return "0x" + awareness.Value.ToString("X16");
    }

    [SupportedOSPlatform("windows6.1")]
    public static int AdjustForWindowDpi(int value, HWND handle)
    {
        var dpi = GetDpiForWindow(handle);
        if (dpi.width == USER_DEFAULT_SCREEN_DPI)
            return value;

        return (int)(value * dpi.width / USER_DEFAULT_SCREEN_DPI);
    }

    [SupportedOSPlatform("windows6.1")]
    public static float AdjustForWindowDpi(float value, HWND handle)
    {
        var dpi = GetDpiForWindow(handle);
        if (dpi.width == USER_DEFAULT_SCREEN_DPI)
            return value;

        return value * dpi.width / USER_DEFAULT_SCREEN_DPI;
    }

    private delegate int GetDpiForWindowFn(nint hwnd);
    private unsafe delegate int GetDpiForMonitorFn(nint hmonitor, MONITOR_DPI_TYPE dpiType, uint* dpiX, uint* dpiY);
}
