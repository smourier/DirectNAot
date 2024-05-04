using Microsoft.Win32;

namespace DirectNAot.Extensions.Utilities
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
        public static D2D_SIZE_U GetDpiForWindow(IntPtr hwnd)
        {
            using var pwstr = new Pwstr("user32.dll");
            var module = Functions.LoadLibraryW(pwstr);
            try
            {
                using var pstr = new Pstr("GetDpiForWindow");
                var proc = Functions.GetProcAddress(module, pstr); // Windows 10 1607
                if (proc == null)
                    return GetDpiForNearestMonitor(hwnd);

                throw new NotImplementedException();
                //var dpi = Marshal.GetDelegateForFunctionPointer<GetDpiForWindowFn>(proc)(hwnd);
                //return new D2D_SIZE_U((uint)dpi, (uint)dpi);
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
        public static D2D_SIZE_U GetDpiForNearestMonitor(IntPtr hwnd) => throw new NotImplementedException();// GetDpiForMonitor(Functions.MonitorFromWindow(Monitor.GetNearestFromWindow(hwnd));

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForNearestMonitor(int x, int y) => throw new NotImplementedException();// GetDpiForMonitor(Monitor.GetNearestFromPoint(x, y));

        [SupportedOSPlatform("windows6.1")]
        public static D2D_SIZE_U GetDpiForMonitor(IntPtr monitor, MONITOR_DPI_TYPE type = MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI)
        {
            if (monitor == IntPtr.Zero)
                return new D2D_SIZE_U(96, 96);

            using var pwstr = new Pwstr("shcore.dll");
            var module = Functions.LoadLibraryW(pwstr);
            try
            {
                using var pstr = new Pstr("GetDpiForMonitor");
                var proc = Functions.GetProcAddress(module, pstr); // Windows 8.1
                if (proc == null)
                    return GetDpiForDesktop();

                throw new NotImplementedException();
                //var hr = Marshal.GetDelegateForFunctionPointer<GetDpiForMonitorFn>(proc)(monitor, type, out int x, out int y);
                //if (hr < 0)
                //    return GetDpiForDesktop();

                //return new D2D_SIZE_U((uint)x, (uint)y);
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
        public static D2D_SIZE_U GetDpiForDesktop()
        {
            var dpi = Functions.GetDesktopDpi();
            return new D2D_SIZE_U((uint)dpi.width, (uint)dpi.height);
        }

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

        public static int AdjustForWindowDpi(int value, IntPtr handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return (int)(value * dpi.width / 96);
        }

        public static float AdjustForWindowDpi(float value, IntPtr handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return value * dpi.width / 96;
        }

        private delegate int GetDpiForWindowFn(IntPtr hwnd);
        private delegate int GetDpiForMonitorFn(IntPtr hmonitor, MONITOR_DPI_TYPE dpiType, out int dpiX, out int dpiY);
    }
}
