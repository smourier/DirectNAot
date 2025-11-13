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

    public void CopyTo(nint target, uint size = uint.MaxValue)
    {
        if (target == 0)
            throw new ArgumentException(null, nameof(target));

        if (size == uint.MaxValue)
        {
            size = Size;
        }
        if (size == 0)
            return;

        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - size);
        Pointer.CopyTo(target, size);
    }

    public void CopyFrom(nint source, uint size = uint.MaxValue)
    {
        if (source == 0)
            throw new ArgumentException(null, nameof(source));

        if (size == uint.MaxValue)
        {
            size = Size;
        }
        if (size == 0)
            return;

        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - size);
        source.CopyTo(Pointer, size);
    }

    public byte[] ToArray()
    {
        var array = new byte[Size];
        Marshal.Copy(Pointer, array, 0, (int)Size);
        return array;
    }

    public byte[] ToArray(uint offset, uint count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - (offset + count));
        var array = new byte[count];
        Marshal.Copy(Pointer + (nint)offset, array, 0, (int)count);
        return array;
    }

    public unsafe T[] ToArray<T>() where T : unmanaged
    {
        var count = Size / (uint)sizeof(T);
        return ToArray<T>(0, count);
    }

    public unsafe T[] ToArray<T>(uint offset, uint count) where T : unmanaged
    {
        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - (offset + count * (uint)sizeof(T)));
        var array = new T[count];
        fixed (T* pArray = array)
        {
            Unsafe.CopyBlock(pArray, (void*)(Pointer + (nint)offset), count * (uint)sizeof(T));
        }
        return array;
    }

    public unsafe Span<T> AsSpan<T>(uint count = uint.MaxValue) where T : unmanaged
    {
        if (count == uint.MaxValue)
        {
            count = Size / (uint)sizeof(T);
        }
        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - count * (uint)sizeof(T));
        unsafe
        {
            return new Span<T>((void*)Pointer, (int)count);
        }
    }

    public unsafe void Write<T>(ref T value, uint offset = 0) where T : unmanaged
    {
        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - offset - (uint)sizeof(T));
        Unsafe.CopyBlock((void*)(Pointer + (nint)offset), Unsafe.AsPointer(ref value), (uint)sizeof(T));
    }

    public unsafe T Read<T>(uint offset = 0) where T : unmanaged
    {
        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - offset - (uint)sizeof(T));
        return Unsafe.AsRef<T>((void*)(Pointer + (nint)offset));
    }

    public Span<byte> AsSpan(uint size = uint.MaxValue)
    {
        if (size == uint.MaxValue)
        {
            size = Size;
        }

        ArgumentOutOfRangeException.ThrowIfNegative((long)Size - size);
        unsafe
        {
            return new Span<byte>((void*)Pointer, (int)size);
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

    public static unsafe ComMemory From<T>(T item) where T : unmanaged
    {
        var mem = new ComMemory(sizeof(T));
        mem.CopyFrom((nint)Unsafe.AsPointer(ref item));
        return mem;
    }

    public static unsafe ComMemory FromEnumerable<T>(IEnumerable<T> items) where T : unmanaged
    {
        if (items == null)
            return new ComMemory(0);

        var array = items.ToArray();
        if (array == null)
            return new ComMemory(0);

        var mem = new ComMemory(array.Length * sizeof(T));
        mem.CopyFrom(array.AsPointer());
        return mem;
    }

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

    public System.IO.UnmanagedMemoryStream ToUnmanagedMemoryStream(FileAccess access = FileAccess.ReadWrite, bool owned = false) => new(new IntPtrBuffer(this, owned), 0, Size, access);
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
