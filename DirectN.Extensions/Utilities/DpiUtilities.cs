namespace DirectN.Extensions.Utilities
{
    // note this class considers dpix = dpiy
    public static class DpiUtilities
    {
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
        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForWindow(HWND hwnd)
        {
            var module = Functions.LoadLibraryW(PWSTR.From("user32.dll"));
            try
            {
                using var pstr = new Pstr("GetDpiForWindow");
                var proc = Functions.GetProcAddress(module, pstr); // Windows 10 1607
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

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForNearestMonitor(HWND hwnd) => GetDpiForMonitor(Functions.MonitorFromWindow(hwnd, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST));

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForNearestMonitor(int x, int y) => GetDpiForMonitor(Functions.MonitorFromPoint(new POINT(x, y), MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST));

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForMonitor(HMONITOR monitor, MONITOR_DPI_TYPE type = MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI)
        {
            if (monitor.Value == 0)
                return new D2D_SIZE_U(96, 96);

            var module = Functions.LoadLibraryW(PWSTR.From("shcore.dll"));
            try
            {
                using var pstr = new Pstr("GetDpiForMonitor");
                var proc = Functions.GetProcAddress(module, pstr); // Windows 8.1
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

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_F GetDpiForDesktopF() => Functions.GetDesktopDpi();

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForDesktop() { var dpi = Functions.GetDesktopDpi(); return new D2D_SIZE_U((uint)dpi.width, (uint)dpi.height); }

        [SupportedOSPlatform("windows10.0.17134")]
        public static uint GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value)
        {
            // Windows 10, version 1803
            // see here for correspondance https://en.wikipedia.org/wiki/Windows_10_version_history
            if (WindowsVersionUtilities.KernelVersion >= new Version(10, 0, 17134))
                return Functions.GetDpiFromDpiAwarenessContext(value);

            return 0;
        }

        [SupportedOSPlatform("windows10.0.17134")]
        public static uint GetWindowDpi(HWND hwnd) => GetDpiFromDpiAwarenessContext(GetWindowDpiAwarenessContext(hwnd));

        [SupportedOSPlatform("windows10.0.17134")]
        public static DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(HWND hwnd)
        {
            // Windows 10, version 1607
            // see here for correspondance https://en.wikipedia.org/wiki/Windows_10_version_history
            if (WindowsVersionUtilities.KernelVersion >= new Version(10, 0, 14393))
                return Functions.GetWindowDpiAwarenessContext(hwnd);

            return DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_INVALID;
        }

        [SupportedOSPlatform("windows6.1")]
        public static int AdjustForWindowDpi(int value, HWND handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return (int)(value * dpi.width / 96);
        }

        [SupportedOSPlatform("windows6.1")]
        public static float AdjustForWindowDpi(float value, HWND handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return value * dpi.width / 96;
        }

        private delegate int GetDpiForWindowFn(nint hwnd);
        private unsafe delegate int GetDpiForMonitorFn(nint hmonitor, MONITOR_DPI_TYPE dpiType, uint* dpiX, uint* dpiY);
    }
}
