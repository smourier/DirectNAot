namespace DirectN.Extensions.Com;

public class ComBuffer : SafeBuffer
{
    public ComBuffer(nint pointer, long byteLength)
        : base(false)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(byteLength);
        handle = pointer;
        Initialize((ulong)byteLength);
    }

    public ComBuffer(int byteLength)
        : base(true)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(byteLength);
        if (byteLength > 0)
        {
            handle = Marshal.AllocCoTaskMem(byteLength);
            if (handle == 0)
                throw new OutOfMemoryException();
        }

        Owned = true;
        Initialize((ulong)byteLength);
    }

    public ComBuffer(uint byteLength)
        : base(true)
    {
        if (byteLength > 0)
        {
            handle = Marshal.AllocCoTaskMem((int)byteLength);
            if (handle == 0)
                throw new OutOfMemoryException();
        }

        Owned = true;
        Initialize(byteLength);
    }

    public bool Owned { get; }

    protected override bool ReleaseHandle()
    {
        if (!Owned || handle == 0)
            return true;

        Marshal.FreeCoTaskMem(handle);
        handle = 0;
        return true;
    }

    public unsafe static ComBuffer From<T>(T? value) where T : unmanaged
    {
        var buffer = new ComBuffer(sizeof(T));
        if (value.HasValue)
        {
            *(T*)buffer.handle = value.Value;
        }
        return buffer;
    }
}

public class ComBuffer<T> : ComBuffer where T : unmanaged
{
    public unsafe ComBuffer(T value)
        : base((uint)sizeof(T))
    {
        *(T*)handle = value;
    }

    public unsafe ComBuffer()
    : base((uint)sizeof(T))
    {
    }

    public unsafe ref T RefValue => ref Unsafe.AsRef<T>((void*)handle);
    public unsafe T Value => *(T*)handle;
}