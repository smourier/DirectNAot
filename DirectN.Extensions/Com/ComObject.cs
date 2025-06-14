using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Com;

public abstract class ComObject : IComObject
{
    public static ComWrappers ComWrappers { get; } = new StrategyBasedComWrappers();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private System.Runtime.InteropServices.Marshalling.ComObject? _comObject;

#if DEBUG
    internal static long _uniqueId;
    internal long _id;

    public static bool EnableTraces { get; set; } = false;

    internal static void StaticTrace(object? message = null, [CallerMemberName] string? methodName = null)
    {
        if (!EnableTraces)
            return;

        Application.TraceVerbose($"{message}", methodName);
    }

    internal void Trace(object? message = null, [CallerMemberName] string? methodName = null)
    {
        if (!EnableTraces)
            return;

        Application.TraceVerbose($"{_id}|{message}", methodName);
    }
#endif

    public ComObject(object comObject, bool releaseOnDispose = true)
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

    public void AddRef() => AddRef(Object);

    [AllowNull]
    public System.Runtime.InteropServices.Marshalling.ComObject Object
    {
        get
        {
            var obj = _comObject;
#if DEBUG
            if (obj == null)
            {
                Trace("Object is disposed.");
            }
#endif
            ObjectDisposedException.ThrowIf(obj == null, this);
            return obj;
        }
    }

    public static void AddRef(object obj)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace();
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName}");
        }
#endif
        ArgumentNullException.ThrowIfNull(obj);
        var unwrapped = Unwrap(obj);
        if (unwrapped == null)
            throw new ArgumentException(null, nameof(obj));

        ComWrappers.TryGetComInstance(unwrapped, out var unk);
        if (unk == 0)
            throw new ArgumentException(null, nameof(obj));

        // just don't release
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

    public static nint GetUnknown(nint pointer, bool throwOnError = true) => QueryInterface(pointer, typeof(IUnknown).GUID, throwOnError);
    public static nint QueryInterface(nint pointer, Guid iid, bool throwOnError = true)
    {
        if (pointer == 0)
            return throwOnError ? Constants.E_POINTER.ThrowOnError() : 0;

        HRESULT hr = Marshal.QueryInterface(pointer, iid, out var unk);
        hr.ThrowOnError(throwOnError);
        return unk;
    }

    public static IComObject<T>? FromPointer<T>(nint unknown, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true)
    {
#if DEBUG
        StaticTrace($"unknown:{unknown} releaseOnDispose:{releaseOnDispose}");
#endif
        if (unknown == 0)
            return null;

        var instance = ComWrappers.GetOrCreateObjectForComInstance(unknown, flags);
        if (flags == CreateObjectFlags.UniqueInstance)
        {
            Marshal.Release(unknown);
        }
        if (instance == null || instance is not T t)
            return null;

        return new ComObject<T>(t, releaseOnDispose);
    }

    public static nint GetOrCreateComInstance(object? obj, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None, bool throwOnError = false)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace();
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName}");
        }
#endif
        if (obj == null)
            return 0;

        var unwrapped = Unwrap(obj);
        if (unwrapped == null)
            return 0;

        ComWrappers.TryGetComInstance(unwrapped, out var unk);
        if (unk != 0)
            return unk;

        if (throwOnError)
            return ComWrappers.GetOrCreateComInterfaceForObject(unwrapped, flags);

        try
        {
            return ComWrappers.GetOrCreateComInterfaceForObject(unwrapped, flags);
        }
        catch
        {
            return 0;
        }
    }

    public static nint GetOrCreateComInstance<T>(object? obj, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None, bool throwOnError = false) => GetOrCreateComInstance(obj, typeof(T).GUID, flags, throwOnError);
    public static nint GetOrCreateComInstance(object? obj, Guid iid, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None, bool throwOnError = false)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace($"iid:{iid.GetConstantName()}");
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName} iid:{iid.GetConstantName()}");
        }
#endif
        if (obj == null)
            return 0;

        var unk = GetOrCreateComInstance(obj, flags, throwOnError);
        if (unk == 0 || iid == typeof(IUnknown).GUID)
            return unk;

        try
        {
            var hr = Marshal.QueryInterface(unk, iid, out var iface);
            if (throwOnError && hr < 0)
                Marshal.ThrowExceptionForHR(hr);

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
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, iid, out var iface));
            return iface;
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static void Release(System.Runtime.InteropServices.Marshalling.ComObject? obj) => ComExtensions.FinalRelease(obj);
    public static int Release(nint unknown)
    {
#if DEBUG
        StaticTrace($"unknown:{unknown}");
#endif
        if (unknown == 0)
            return 0;

        return Marshal.Release(unknown);
    }

    public static void WithComInstance(object? obj, Action<nint> action, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace();
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName}");
        }
#endif
        ArgumentNullException.ThrowIfNull(action);
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj, throwOnError: throwIfZero);
        }

        if (unk == 0 && obj != null && throwIfZero)
            throw new ArgumentException(null, nameof(obj));

        try
        {
            action(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static T WithComInstance<T>(object? obj, Func<nint, T> func, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace($"type:{typeof(T).FullName}");
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName} type:{typeof(T).FullName}");
        }
#endif
        ArgumentNullException.ThrowIfNull(func);
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj, throwOnError: throwIfZero);
        }

        if (unk == 0 && obj != null && throwIfZero)
            throw new ArgumentException(null, nameof(obj));

        try
        {
            return func(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static void WithComInstanceOfType<T>(object? obj, Action<nint> action, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace($"type:{typeof(T).FullName}");
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName} type:{typeof(T).FullName}");
        }
#endif
        ArgumentNullException.ThrowIfNull(action);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj, throwOnError: throwIfZero);
        }

        if (unk != 0)
        {
            var iid = typeof(T).GUID;
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, iid, out iface));
        }
        else
        {
            if (obj != null && throwIfZero)
                throw new ArgumentException(null, nameof(obj));
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

    public static T WithComInstanceOfType<T, Ti>(object? obj, Func<nint, T> func, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        if (obj is ComObject co)
        {
            co.Trace($"type:{typeof(T).FullName}");
        }
        else
        {
            StaticTrace($"obj:{obj?.GetType().FullName} type:{typeof(T).FullName}");
        }
#endif
        ArgumentNullException.ThrowIfNull(func);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk == 0 && createIfNeeded)
        {
            unk = GetOrCreateComInstance(obj, throwOnError: throwIfZero);
        }

        if (unk != 0)
        {
            var iid = typeof(Ti).GUID;
            Marshal.ThrowExceptionForHR(Marshal.QueryInterface(unk, iid, out iface));
        }
        else
        {
            if (obj != null && throwIfZero)
                throw new ArgumentException(null, nameof(obj));
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

    public static void WithComInstancesOfType<T>(IReadOnlyCollection<T>? array, Action<nint> action, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        StaticTrace($"array:{array?.Count}");
#endif

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
                unk = GetOrCreateComInstance(item, throwOnError: throwIfZero);
            }

            if (unk != 0)
            {
                var iid = typeof(T).GUID;
                var hr = Marshal.QueryInterface(unk, iid, out iface);
                Marshal.Release(unk);
                Marshal.ThrowExceptionForHR(hr);
            }
            else
            {
                if (item != null && throwIfZero)
                    throw new ArgumentException(null, nameof(array));
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

    public static T WithComInstancesOfType<T, Ti>(IReadOnlyCollection<Ti>? array, Func<nint, T> action, bool createIfNeeded = false, bool throwIfZero = true)
    {
#if DEBUG
        StaticTrace($"array:{array?.Count}");
#endif

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
                unk = GetOrCreateComInstance(item, throwOnError: throwIfZero);
            }

            if (unk != 0)
            {
                var iid = typeof(Ti).GUID;
                var hr = Marshal.QueryInterface(unk, iid, out iface);
                Marshal.Release(unk);
                Marshal.ThrowExceptionForHR(hr);
            }
            else
            {
                if (item != null && throwIfZero)
                    throw new ArgumentException(null, nameof(array));
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

    public static IComObject<T>? CoCreate<T>(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, nint outer = 0, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true, bool throwOnError = true)
    {
#if DEBUG
        StaticTrace($"classId:{classId} ctx:{ctx}");
#endif
        // we use IUnknown first, some objects don't support direct query interface
        Functions.CoCreateInstance(classId, outer, ctx, typeof(IUnknown).GUID, out var unk).ThrowOnError(throwOnError);
        return FromPointer<T>(unk, flags, releaseOnDispose);
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T>? GetActivationFactory<T>(string activatableClassId, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true, bool throwOnError = true)
    {
#if DEBUG
        StaticTrace($"activatableClassId:{activatableClassId}");
#endif
        ArgumentNullException.ThrowIfNull(activatableClassId);
        using var p = new Hstring(activatableClassId);
        Functions.RoGetActivationFactory(p, typeof(T).GUID, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return default;

        return FromPointer<T>(unk, flags, releaseOnDispose);
    }

    [SupportedOSPlatform("windows8.0")]
    public static object? GetActivationFactory(string activatableClassId, Guid iid, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true)
    {
#if DEBUG
        StaticTrace($"activatableClassId:{activatableClassId} iid:{iid.GetConstantName()}");
#endif
        ArgumentNullException.ThrowIfNull(activatableClassId);
        using var p = new Hstring(activatableClassId);
        Functions.RoGetActivationFactory(p, iid, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return null;

        return ComWrappers.GetOrCreateObjectForComInstance(unk, flags);
    }

    protected virtual void Dispose(bool disposing)
    {
#if DEBUG
        Trace($"disposing:{disposing} releaseOnDispose:{ReleaseOnDispose}");
#endif
        if (disposing && ReleaseOnDispose)
        {
            ComExtensions.FinalRelease(Interlocked.Exchange(ref _comObject, null));
        }
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}

public class ComObject<T> : ComObject, IComObject<T>
{
    public ComObject(object comObject, bool releaseOnDispose = true)
        : base((T)comObject, releaseOnDispose)
    {
#if DEBUG
        _id = Interlocked.Increment(ref _uniqueId);
        Trace($"{comObject.GetType().Name} type:{typeof(T).FullName} releaseOnDispose:{releaseOnDispose}");
#endif
    }

    [AllowNull]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public new T Object => (T)(object)base.Object;
    public override Type InterfaceType => typeof(T);

    public static IComObject<T>? CoCreate(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, nint outer = 0, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true, bool throwOnError = true) => CoCreate<T>(classId, ctx, outer, flags, releaseOnDispose, throwOnError);
}
