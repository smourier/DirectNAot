namespace DirectN.Extensions.Utilities;

public static class WindowMessageHook
{
    public delegate LRESULT? MessageHandler(uint message, WPARAM wParam, LPARAM lParam);

    private const uint _subclassId = 1;
    private static readonly ConcurrentDictionary<HWND, MessageHandler> _handlers = new();
    private static readonly SUBCLASSPROC _subclassProc = SubclassProc;

    public static void Attach(HWND hwnd, MessageHandler handler)
    {
        ArgumentNullException.ThrowIfNull(handler);
        if (hwnd == HWND.Null)
            return;

        _handlers[hwnd] = handler;
        Functions.SetWindowSubclass(hwnd, _subclassProc, _subclassId, 0);
    }

    public static void Detach(HWND hwnd)
    {
        if (_handlers.TryRemove(hwnd, out _))
        {
            Functions.RemoveWindowSubclass(hwnd, _subclassProc, _subclassId);
        }
    }

    private static LRESULT SubclassProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam, nuint idSubclass, nuint refData)
    {
        try
        {
            if (_handlers.TryGetValue(hwnd, out var handler) && handler(msg, wParam, lParam) is LRESULT result)
                return result;
        }
        catch
        {
            // a managed exception must never propagate across the native callback boundary
        }

        return Functions.DefSubclassProc(hwnd, msg, wParam, lParam);
    }
}
