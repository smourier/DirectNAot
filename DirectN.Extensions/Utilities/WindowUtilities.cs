namespace DirectN.Extensions.Utilities;

public static class WindowUtilities
{
    public static uint GetPointerId(this WPARAM wParam) => wParam.Value.LOWORD();
    public static POINTER_MESSAGE_FLAGS GetPointerFlags(this WPARAM wParam) => (POINTER_MESSAGE_FLAGS)wParam.Value.HIWORD();
    public static int GetWheelDelta(this WPARAM wParam) => (int)wParam.Value.HIWORD();

    [SupportedOSPlatform("windows8.0")]
    public static POINTER_INPUT_TYPE GetPointerType(uint id)
    {
        Functions.GetPointerType(id, out var type);
        return type;
    }

    [SupportedOSPlatform("windows8.0")]
    public static POINTER_INFO GetPointerInfo(uint id)
    {
        Functions.GetPointerInfo(id, out var info);
        return info;
    }

    [SupportedOSPlatform("windows8.0")]
    public static POINTER_TOUCH_INFO GetPointerTouchInfo(uint id)
    {
        Functions.GetPointerTouchInfo(id, out var info);
        return info;
    }

    [SupportedOSPlatform("windows8.0")]
    public static POINTER_PEN_INFO GetPointerPenInfo(uint id)
    {
        Functions.GetPointerPenInfo(id, out var info);
        return info;
    }

    public static POINT GetCursorPosition() { Functions.GetCursorPos(out var pt); return pt; }
    public static char VirtualKeyToCharacter(VIRTUAL_KEY vk) => (char)Functions.MapVirtualKeyW((uint)vk, MAP_VIRTUAL_KEY_TYPE.MAPVK_VK_TO_CHAR);
    public static bool IsKeyPressed(VIRTUAL_KEY vk, bool async = true) => (async ? Functions.GetAsyncKeyState((int)vk) : Functions.GetKeyState((int)vk)) < 0;
    public static IReadOnlyList<HWND> EnumerateTopLevelWindows()
    {
        var list = new List<HWND>();
        _ = Functions.EnumWindows((h, l) => { list.Add(h); return true; }, 0);
        return list.AsReadOnly();
    }

    public static IReadOnlyList<HWND> EnumerateChildWindows(HWND handle)
    {
        var list = new List<HWND>();
        _ = Functions.EnumChildWindows(handle, (h, l) => { list.Add(h); return true; }, 0);
        return list.AsReadOnly();
    }

    public static IReadOnlyList<HWND> EnumerateProcessWindows(int processId)
    {
        try
        {
            return EnumerateProcessWindows(Process.GetProcessById(processId));
        }
        catch
        {
            return [];
        }
    }

    public static IReadOnlyList<HWND> EnumerateProcessWindows(Process? process)
    {
        if (process == null)
            return [];

        IEnumerable<ProcessThread> threads;
        try
        {
            threads = process.Threads.Cast<ProcessThread>();
        }
        catch
        {
            return [];
        }

        var list = new List<HWND>();
        foreach (var thread in threads)
        {
            _ = Functions.EnumThreadWindows((uint)thread.Id, (h, l) => { list.Add(h); return true; }, 0);
        }
        return list.AsReadOnly();
    }

    public static unsafe bool Center(HWND handle, HWND alternateOwner)
    {
        var parentHandle = Functions.GetParent(handle);
        var ownerHandle = Functions.GetWindow(handle, GET_WINDOW_CMD.GW_OWNER);
        var style = (WINDOW_STYLE)Functions.GetWindowLongW(handle, WINDOW_LONG_PTR_INDEX.GWL_STYLE);
        var hwndCenter = alternateOwner;
        if (alternateOwner.Value == 0)
        {
            if (style.HasFlag(WINDOW_STYLE.WS_CHILD))
            {
                hwndCenter = parentHandle;
            }
            else
            {
                hwndCenter = ownerHandle;
            }
        }

        // get coordinates of the window relative to its parent
        Functions.GetWindowRect(handle, out var rc);
        RECT area;
        RECT center;
        if (!style.HasFlag(WINDOW_STYLE.WS_CHILD))
        {
            // don't center against invisible or minimized windows
            if (hwndCenter.Value != 0)
            {
                var alternateStyle = (WINDOW_STYLE)Functions.GetWindowLongW(hwndCenter, WINDOW_LONG_PTR_INDEX.GWL_STYLE);
                if (!alternateStyle.HasFlag(WINDOW_STYLE.WS_VISIBLE) || alternateStyle.HasFlag(WINDOW_STYLE.WS_MINIMIZE))
                {
                    hwndCenter = HWND.Null;
                }
            }

            var mi = new MONITORINFO
            {
                cbSize = (uint)sizeof(MONITORINFO)
            };

            // center within appropriate monitor coordinates
            if (hwndCenter.Value == 0)
            {
                var hwDefault = handle;
                Functions.GetMonitorInfoW(Functions.MonitorFromWindow(hwDefault, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTOPRIMARY), ref mi);
                center = mi.rcWork;
                area = mi.rcWork;
            }
            else
            {
                center = rc;
                Functions.GetMonitorInfoW(Functions.MonitorFromWindow(hwndCenter, MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST), ref mi);
                area = mi.rcWork;
            }
        }
        else
        {
            // center within parent client coordinates
            Functions.GetClientRect(handle, out var cr);
            area = cr;
            center = cr;
            var pts = Unsafe.AsRef<POINT[]>(&center);
            Functions.MapWindowPoints(hwndCenter, parentHandle, pts, 2);
        }

        // find dialog's upper left based on rcCenter
        var left = (center.left + center.right) / 2 - rc.Width / 2;
        var top = (center.top + center.bottom) / 2 - rc.Height / 2;

        // if the dialog is outside the screen, move it inside
        if (left + rc.Width > area.right)
        {
            left = area.right - rc.Width;
        }

        if (left < area.left)
        {
            left = area.left;
        }

        if (top + rc.Height > area.bottom)
        {
            top = area.bottom - rc.Height;
        }

        if (top < area.top)
        {
            top = area.top;
        }

        // map screen coordinates to child coordinates
        return Functions.SetWindowPos(handle, HWND.Null, left, top, -1, -1, SET_WINDOW_POS_FLAGS.SWP_NOSIZE | SET_WINDOW_POS_FLAGS.SWP_NOZORDER | SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE);
    }

    // https://stackoverflow.com/a/61681245/403671
    public static RECT GetWindowCaptionRect(HWND handle) => GetWindowCaptionRect(DpiUtilities.GetDpiForWindow(handle).width);
    public static RECT GetWindowCaptionRect(uint dpi)
    {
        var rc = new RECT();
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 14393))
        {
            Functions.AdjustWindowRectExForDpi(ref rc, WINDOW_STYLE.WS_OVERLAPPEDWINDOW, false, 0, dpi);
        }
        else
        {
            Functions.AdjustWindowRectEx(ref rc, WINDOW_STYLE.WS_OVERLAPPEDWINDOW, false, 0);
        }
        return rc;
    }
}
