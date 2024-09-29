namespace DirectN.Extensions.Utilities;

public partial class Monitor
{
    public unsafe Monitor(HMONITOR handle)
    {
        Handle = handle;
        var mix = new MONITORINFOEXW();
        mix.monitorInfo.cbSize = (uint)sizeof(MONITORINFOEXW);
        if (!Functions.GetMonitorInfoW(handle, ref mix))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        DeviceName = mix.szDevice.ToString();
        Bounds = mix.monitorInfo.rcMonitor;
        WorkingArea = mix.monitorInfo.rcWork;
        IsPrimary = (mix.monitorInfo.dwFlags & Constants.MONITORINFOF_PRIMARY) == Constants.MONITORINFOF_PRIMARY;
    }

    public HMONITOR Handle { get; }
    public bool IsPrimary { get; }
    public RECT WorkingArea { get; }
    public RECT Bounds { get; }

    [Browsable(false)]
    public string DeviceName { get; }

    [SupportedOSPlatform("windows6.1")]
    public D2D_SIZE_U EffectiveDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI);

    [SupportedOSPlatform("windows6.1")]
    public D2D_SIZE_U RawDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_RAW_DPI);

    [SupportedOSPlatform("windows6.1")]
    public D2D_SIZE_U AngularDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_ANGULAR_DPI);

    [SupportedOSPlatform("windows8.1")]
    public DEVICE_SCALE_FACTOR ScaleFactor
    {
        get
        {
            _ = Functions.GetScaleFactorForMonitor(Handle, out var factor);
            return factor;
        }
    }

    [Browsable(false)]
    public DisplayDevice? DisplayDevice
    {
        get
        {
            foreach (var dd in DisplayDevice.All)
            {
                if (dd.DeviceName.EqualsIgnoreCase(DeviceName))
                    return dd;
            }
            return null;
        }
    }

    public override string ToString() => DeviceName;

    public static Monitor? Desktop
    {
        get
        {
            var handle = GetDesktopMonitorHandle();
            return handle.Value == 0 ? null : new Monitor(handle);
        }
    }

    public static Monitor? Shell
    {
        get
        {
            var handle = GetShellMonitorHandle();
            return handle.Value == 0 ? null : new Monitor(handle);
        }
    }

    public static HMONITOR GetNearestFromWindow(HWND hwnd) => Functions.MonitorFromWindow(hwnd, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST);
    public static HMONITOR GetNearestFromPoint(int x, int y) => Functions.MonitorFromPoint(new POINT { x = x, y = y }, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST);
    public static HMONITOR GetDesktopMonitorHandle() => GetNearestFromWindow(Functions.GetDesktopWindow());
    public static HMONITOR GetShellMonitorHandle() => GetNearestFromWindow(Functions.GetShellWindow());

    public static Monitor? FromWindow(HWND hwnd, MONITOR_FROM_FLAGS flags = MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONULL)
    {
        var h = Functions.MonitorFromWindow(hwnd, flags);
        if (h.Value == 0)
            return null;

        return new Monitor(h);
    }

    public static Monitor? Primary => All.FirstOrDefault(m => m.IsPrimary);
    public static IEnumerable<Monitor> All
    {
        get
        {
            var all = new List<Monitor>();
            Functions.EnumDisplayMonitors(HDC.Null, 0, (m, h, rc, p) =>
            {
                all.Add(new Monitor(m));
                return true;
            }, LPARAM.Null);
            return all;
        }
    }
}
