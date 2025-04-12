namespace DirectN.Extensions.Utilities;

public sealed class LockedHGLOBALBuffer : SafeBuffer
{
    private nint _handle;

    public LockedHGLOBALBuffer(HGLOBAL handle)
        : base(true)
    {
        this.handle = Functions.GlobalLock(handle);
        Initialize(Functions.GlobalSize(handle));
        _handle = handle.Value;
    }

    protected override bool ReleaseHandle()
    {
        var h = Interlocked.Exchange(ref _handle, 0);
        if (h != 0)
        {
            Functions.GlobalUnlock(h);
        }
        return true;
    }
}
