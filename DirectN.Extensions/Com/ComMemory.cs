namespace DirectN.Extensions.Com;

public class ComMemory : IEquatable<ComMemory>, IDisposable
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private nint _pointer;

    public ComMemory(int size)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(size);
        Size = (uint)size;
        if (size > 0)
        {
            _pointer = Marshal.AllocCoTaskMem(size);
        }
    }

    public ComMemory(uint size)
    {
        Size = size;
        if (size > 0)
        {
            _pointer = Marshal.AllocCoTaskMem((int)size);
        }
    }

    public uint Size { get; protected set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected nint RawPointer => _pointer;

    public nint Pointer
    {
        get
        {
            var pointer = _pointer;
            ObjectDisposedException.ThrowIf(pointer == 0 && Size != 0, this);
            return pointer!;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
            return;

        var pointer = Interlocked.Exchange(ref _pointer, 0);
        if (pointer != 0)
        {
            Marshal.FreeCoTaskMem(pointer);
        }
    }

    public override int GetHashCode() => _pointer.GetHashCode() ^ Size.GetHashCode();
    public override bool Equals(object? obj) => Equals(obj as ComMemory);
    public virtual bool Equals(ComMemory? other) => other != null && other.Size == Size && other._pointer == _pointer;
    public override string ToString() => $"{_pointer} ({Size})";

    ~ComMemory() { Dispose(false); }
    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }

    public static void WithAllocatedMemory(uint size, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (size == 0)
        {
            action(0);
            return;
        }

        using var mem = new ComMemory(size);
        action(mem.Pointer);
    }

    public static T WithAllocatedMemory<T>(uint size, Func<nint, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (size == 0)
            return func(0);

        using var mem = new ComMemory(size);
        return func(mem.Pointer);
    }
}

public class ComMemory<T> : ComMemory where T : unmanaged
{
    public unsafe ComMemory()
        : base((uint)sizeof(T))
    {
    }

    public unsafe ComMemory(T structure)
        : this()
    {
        Unsafe.CopyBlock((void*)Pointer, Unsafe.AsPointer(ref structure), (uint)sizeof(T));
    }

    public unsafe T ToStructure() => Unsafe.AsRef<T>((void*)Pointer);
}
