using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Com;

public abstract class ComObject : IComObject
{
    public static ComWrappers ComWrappers { get; } = new StrategyBasedComWrappers();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private System.Runtime.InteropServices.Marshalling.ComObject? _comObject;

    public ComObject(object? comObject, bool releaseOnDispose = true)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        if (comObject is not System.Runtime.InteropServices.Marshalling.ComObject co)
            throw new ArgumentException(null, nameof(comObject));

        _comObject = co;
        ReleaseOnDispose = releaseOnDispose;
    }

    public abstract Type InterfaceType { get; }
    public bool ReleaseOnDispose { get; }
    public bool IsDisposed => _comObject == null;

    [AllowNull]
    public System.Runtime.InteropServices.Marshalling.ComObject Object
    {
        get
        {
            var obj = _comObject;
            ObjectDisposedException.ThrowIf(obj == null, this);
            return obj;
        }
    }

    public static object? Unwrap(object? obj)
    {
        if (obj is IComObject ico)
            return ico.Object;

        return obj;
    }

    public static T? Unwrap<T>(object obj)
    {
        if (obj == null)
            return default;

        if (obj is IComObject<T> ico)
            return ico.Object;

        if (obj is IComObject unko)
        {
            if (unko.Object is T t1)
                return t1;

            return default;
        }

        if (obj is T t)
            return t;

        return default;
    }

    public static IComObject<T>? FromPointer<T>(nint unknown, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance)
    {
        if (unknown == 0)
            return null;

        var instance = ComWrappers.GetOrCreateObjectForComInstance(unknown, flags);
        if (flags == CreateObjectFlags.UniqueInstance)
        {
            Marshal.Release(unknown);
        }
        if (instance == null || instance is not T t)
            return null;

        return new ComObject<T>(t);
    }

    public static nint GetOrCreateComInstance(object obj, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None)
    {
        ArgumentNullException.ThrowIfNull(obj);
        var unwrapped = Unwrap(obj);
        if (unwrapped == null)
            throw new ArgumentException(null, nameof(obj));

        ComWrappers.TryGetComInstance(unwrapped, out var unk);
        if (unk != 0)
            return unk;

        return ComWrappers.GetOrCreateComInterfaceForObject(unwrapped, flags);
    }

    public static nint GetOrCreateComInstance<T>(object obj, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None)
    {
        ArgumentNullException.ThrowIfNull(obj);
        var unk = GetOrCreateComInstance(obj, flags);
        var iid = typeof(T).GUID;
        try
        {
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, ref iid, out var iface));
            return iface;
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static nint ToComInstance(object? obj)
    {
        if (obj == null)
            return 0;

        var unwrapped = Unwrap(obj);
        if (unwrapped == null)
            return 0;

        if (unwrapped is nint unk)
            return unk;

        ComWrappers.TryGetComInstance(unwrapped, out unk);
        return unk;
    }

    public static nint ToComInstanceOfType<T>(object? obj)
    {
        var unk = ToComInstance(obj);
        if (unk == 0)
            return 0;

        var iid = typeof(T).GUID;
        try
        {
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, ref iid, out var iface));
            return iface;
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static void Release(System.Runtime.InteropServices.Marshalling.ComObject? obj) => ComExtensions.FinalRelease(obj);
    public static int Release(nint unk)
    {
        if (unk == 0)
            return 0;

        return Marshal.Release(unk);
    }

    public static void WithComInstance(object? obj, Action<nint> action, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj!);
        }

        try
        {
            action(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static T WithComInstance<T>(object? obj, Func<nint, T> func, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj!);
        }

        try
        {
            return func(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static void WithComInstanceOfType<T>(object? obj, Action<nint> action, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj!);
        }

        if (unk != 0)
        {
            var iid = typeof(T).GUID;
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, ref iid, out iface));
        }

        try
        {
            action(iface);
        }
        finally
        {
            Release(iface);
            Release(unk);
        }
    }

    public static T WithComInstanceOfType<T, Ti>(object? obj, Func<nint, T> func, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj!);
        }

        if (unk != 0)
        {
            var iid = typeof(Ti).GUID;
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, ref iid, out iface));
        }

        try
        {
            return func(iface);
        }
        finally
        {
            Release(iface);
            Release(unk);
        }
    }

    public static void WithComInstancesOfType<T>(IReadOnlyCollection<T>? array, Action<nint> action, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (array == null)
        {
            action(0);
            return;
        }

        var pointers = new nint[array.Count];
        var i = 0;
        foreach (var item in array)
        {
            nint iface = 0;
            var unk = ToComInstance(item);
            if (unk == 0 && createIfNeeded)
            {
                unk = GetOrCreateComInstance(item!);
            }

            if (unk != 0)
            {
                var iid = typeof(T).GUID;
                var hr = Marshal.QueryInterface(unk, ref iid, out iface);
                Marshal.Release(unk);
                Marshal.ThrowExceptionForHR(hr);
            }
            pointers[i++] = iface;
        }

        try
        {
            unsafe
            {
                var arrayPointer = (nint)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(pointers));
                action(arrayPointer);
            }
        }
        finally
        {
            foreach (var ptr in pointers)
            {
                if (ptr != 0)
                {
                    Marshal.Release(ptr);
                }
            }
        }
    }

    public static T WithComInstancesOfType<T, Ti>(IReadOnlyCollection<Ti>? array, Func<nint, T> action, bool createIfNeeded = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (array == null)
            return action(0);

        var pointers = new nint[array.Count];
        var i = 0;
        foreach (var item in array)
        {
            nint iface = 0;
            var unk = ToComInstance(item);
            if (unk == 0 && createIfNeeded)
            {
                unk = GetOrCreateComInstance(item!);
            }

            if (unk != 0)
            {
                var iid = typeof(Ti).GUID;
                var hr = Marshal.QueryInterface(unk, ref iid, out iface);
                Marshal.Release(unk);
                Marshal.ThrowExceptionForHR(hr);
            }
            pointers[i++] = iface;
        }

        try
        {
            unsafe
            {
                var arrayPointer = (nint)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(pointers));
                return action(arrayPointer);
            }
        }
        finally
        {
            foreach (var ptr in pointers)
            {
                if (ptr != 0)
                {
                    Marshal.Release(ptr);
                }
            }
        }
    }

    public static Type? GetComObjectComType(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(ComObject<>))
            return null;

        return type.GetGenericArguments()[0];
    }

    public static IComObject<T>? CoCreate<T>(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, nint outer = 0, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true)
    {
        // we use IUnknown first, some objects don't support direct query interface
        Functions.CoCreateInstance(classId, outer, ctx, typeof(IUnknown).GUID, out var unk).ThrowOnError(throwOnError);
        return FromPointer<T>(unk, flags);
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T>? GetActivationFactory<T>(string activatableClassId, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(activatableClassId);
        using var p = new Hstring(activatableClassId);
        Functions.RoGetActivationFactory(p, typeof(T).GUID, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return default;

        return FromPointer<T>(unk, flags);
    }

    [SupportedOSPlatform("windows8.0")]
    public static object? GetActivationFactory(string activatableClassId, Guid iid, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(activatableClassId);
        using var p = new Hstring(activatableClassId);
        Functions.RoGetActivationFactory(p, iid, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return null;

        return ComWrappers.GetOrCreateObjectForComInstance(unk, flags);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing && ReleaseOnDispose)
        {
            ComExtensions.FinalRelease(Interlocked.Exchange(ref _comObject, null));
        }
    }

    ~ComObject() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}

public class ComObject<T>(object? comObject, bool releaseOnDispose = true) : ComObject((T?)comObject, releaseOnDispose), IComObject<T>
{
    [AllowNull]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public new T Object => (T)(object)base.Object;
    public override Type InterfaceType => typeof(T);

    public static IComObject<T>? CoCreate(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, nint outer = 0, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true) => CoCreate<T>(classId, ctx, outer, flags, throwOnError);
}
