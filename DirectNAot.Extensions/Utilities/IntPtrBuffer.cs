namespace DirectNAot.Extensions.Utilities;

public sealed class IntPtrBuffer : SafeBuffer
{
    public IntPtrBuffer(nint pointer, long byteLength)
        : base(false)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(byteLength);
        handle = pointer;
        Initialize((ulong)byteLength);
    }

    public IntPtrBuffer(int byteLength)
        : base(true)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(byteLength);
        if (byteLength > 0)
        {
            handle = Marshal.AllocHGlobal(byteLength);
            if (handle == 0)
                throw new OutOfMemoryException();
        }

        Owned = true;
        Initialize((ulong)byteLength);
    }

    public bool Owned { get; }

    protected override bool ReleaseHandle()
    {
        if (!Owned || handle == 0)
            return true;

        Marshal.FreeHGlobal(handle);
        handle = 0;
        return true;
    }
}
