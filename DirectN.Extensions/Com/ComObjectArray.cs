namespace DirectN.Extensions.Com;

public sealed class ComObjectArray<T> : IEnumerable<IComObject<T>?>, IDisposable
{
    private readonly Lock _lock = new();
    private readonly List<IComObject<T>?> _list;
    private nint[] _array;

    public ComObjectArray(int capacity = 0, bool disposeOnRemove = true)
    {
        DisposeOnRemove = disposeOnRemove;
        _list = new List<IComObject<T>?>(capacity);
        for (var i = 0; i < capacity; i++)
        {
            _list.Add(null);
        }

        _array = new nint[capacity];
    }

    public ComObjectArray(IEnumerable<IComObject<T>?> items, bool disposeOnRemove = true)
    {
        DisposeOnRemove = disposeOnRemove;
        _list = [];
        var unks = new List<nint>();
        if (items != null)
        {
            foreach (var item in items)
            {
                if (item == null)
                    continue;

                var unk = ComObject.GetOrCreateComInstance(item);
                unks.Add(unk);
                _list.Add(item);
            }
        }
        _array = [.. unks];
    }

    public IComObject<T>? this[int index]
    {
        get => _list[index];
        set
        {
            void setItem()
            {
                var item = _list[index];
                if (DisposeOnRemove)
                {
                    item?.Dispose();
                }
                _list[index] = value;

                var unk = _array[index];
                if (unk != 0)
                {
                    Marshal.Release(unk);
                }

                unk = ComObject.GetOrCreateComInstance(value);
                _array[index] = unk;
            }

            if (ConcurrencyEnabled)
            {
                lock (_lock)
                {
                    setItem();
                }
            }
            else
            {
                setItem();
            }
        }
    }

    public bool DisposeOnRemove { get; }
    public bool ConcurrencyEnabled { get; set; } = true;
    public uint Length => (uint)_array.Length;
    public unsafe nint Pointer => (nint)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(_array));
    public nint[] Array => _array;
    public IReadOnlyList<IComObject<T>?> List => _list;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<IComObject<T>?> GetEnumerator() => _list.GetEnumerator();

    public void Dispose()
    {
        void dispose()
        {
            foreach (var unk in _array)
            {
                if (unk != 0)
                {
                    Marshal.Release(unk);
                }
            }
            Interlocked.Exchange(ref _array, []);

            if (DisposeOnRemove)
            {
                foreach (var item in _list)
                {
                    item?.Dispose();
                }
            }
            _list.Clear();
        }

        if (ConcurrencyEnabled)
        {
            lock (_lock)
            {
                dispose();
            }
        }
        else
        {
            dispose();
        }
    }
}
