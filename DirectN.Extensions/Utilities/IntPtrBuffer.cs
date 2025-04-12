namespace DirectN.Extensions.Utilities;

public sealed class IntPtrBuffer : SafeBuffer
{
    public IntPtrBuffer(nint pointer, long byteLength, bool owned = false)
        : base(owned)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(byteLength);
        handle = pointer;
        Owned = owned;
        Initialize((ulong)byteLength);
    }

    public IntPtrBuffer(ComMemory memory, bool owned = false)
        : base(owned)
    {
        ArgumentNullException.ThrowIfNull(memory);
        handle = memory.Pointer;
        Owned = owned;
        Initialize(memory.Size);
    }

    public IntPtrBuffer(int byteLength)
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

    public IntPtrBuffer(uint byteLength)
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

    public unsafe IntPtrBuffer Clone()
    {
        var size = (uint)ByteLength;
        var buffer = new IntPtrBuffer(size);
        DangerousGetHandle().CopyTo(buffer.DangerousGetHandle(), size);
        return buffer;
    }

    protected override bool ReleaseHandle()
    {
        if (!Owned)
            return true;

        var h = Interlocked.Exchange(ref handle, 0);
        if (h != 0)
        {
            Marshal.FreeCoTaskMem(h);
        }
        return true;
    }

    public unsafe static IntPtrBuffer From<T>(T value) where T : unmanaged
    {
        var buffer = new IntPtrBuffer(sizeof(T));
        *(T*)buffer.handle = value;
        return buffer;
    }
}
