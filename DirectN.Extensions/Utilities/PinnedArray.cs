namespace DirectN.Extensions.Utilities;

public sealed class PinnedArray<T>(T[]? array) : IDisposable where T : unmanaged
{
    private nint _handle = GCHandle.ToIntPtr(GCHandle.Alloc(array?.Length > 0 ? array : null, GCHandleType.Pinned));

    public nint Pointer
    {
        get
        {
            var handle = Volatile.Read(ref _handle);
            ObjectDisposedException.ThrowIf(handle == 0, this);
            return GCHandle.FromIntPtr(handle).AddrOfPinnedObject();
        }
    }

    public void Dispose()
    {
        var handle = Interlocked.Exchange(ref _handle, 0);
        if (handle != 0)
        {
            GCHandle.FromIntPtr(handle).Free();
        }

        GC.SuppressFinalize(this);
    }

    ~PinnedArray()
    {
        Dispose();
    }
}
