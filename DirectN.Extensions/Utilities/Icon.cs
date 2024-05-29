namespace DirectN.Utilities;

public class Icon : IDisposable
{
    private nint _handle;

    public HICON Handle => new() { Value = _handle };

    public static Icon? LoadApplicationIcon(int size = 16)
    {
        var path = Path.GetFileName(Process.GetCurrentProcess().MainModule?.FileName);
        if (path == null)
            return null;

        var exeHandle = Functions.GetModuleHandleW(PWSTR.From(path));
        return FromHandle(Functions.LoadImageW(new HINSTANCE { Value = exeHandle.Value }, Constants.IDI_APPLICATION, GDI_IMAGE_TYPE.IMAGE_ICON, size, size, 0).Value);
    }

    public static Icon? FromHandle(nint handle)
    {
        if (handle == 0)
            return null;

        return new Icon { _handle = handle };
    }

    public static bool Destroy(ref HICON handle)
    {
        if (handle.Value == 0)
            return false;

        var ret = Functions.DestroyIcon(handle);
        if (ret)
        {
            handle = new();
        }
        return ret;
    }

    public static bool Destroy(nint handle)
    {
        if (handle == 0)
            return false;

        return Functions.DestroyIcon(new HICON { Value = handle });
    }

    public static Icon? ExtractAssociatedIcon(string iconPath)
    {
        ArgumentNullException.ThrowIfNull(iconPath);
        ushort icon = 0;
        var handle = Functions.ExtractAssociatedIconW(HINSTANCE.Null, PWSTR.From(iconPath), ref icon).Value;
        if (handle == 0)
            return null;

        return new Icon { _handle = handle };
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var handle = Interlocked.Exchange(ref _handle, 0);
            if (handle != 0)
            {
                Functions.DestroyIcon(new HICON { Value = handle });
            }
        }
    }

    ~Icon() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
