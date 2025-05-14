namespace DirectN.Extensions.Utilities;

public class Font(HFONT handle) : IDisposable
{
    private nint _handle = handle;

    public HFONT Handle => new(_handle);

    public virtual void Set(HWND hwnd) => Functions.SendMessageW(hwnd, MessageDecoder.WM_SETFONT, _handle, BOOL.TRUE.Value);

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var handle = Interlocked.Exchange(ref _handle, 0);
            if (handle != 0)
            {
                Functions.DeleteObject(handle);
            }
        }
    }

    ~Font() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
