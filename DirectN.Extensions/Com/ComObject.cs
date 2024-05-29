﻿using System.Runtime.InteropServices.Marshalling;
using DirectN.Utilities;

namespace DirectN.Extensions.Com;

public abstract class ComObject : IComObject
{
    public static ComWrappers ComWrappers { get; } = new StrategyBasedComWrappers();

    private System.Runtime.InteropServices.Marshalling.ComObject? _comObject;
    private readonly bool _releaseOnDispose;

    public ComObject(object? comObject, bool releaseOnDispose = true)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        if (comObject is not System.Runtime.InteropServices.Marshalling.ComObject co)
            throw new ArgumentException(null, nameof(comObject));

        _comObject = co;
        _releaseOnDispose = releaseOnDispose;
    }

    public abstract Type InterfaceType { get; }
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

    public static nint ToComInstance(object? obj)
    {
        if (obj == null)
            return 0;

        var unwrapped = Unwrap(obj);
        if (unwrapped == null)
            return 0;

        if (unwrapped is nint ptr)
            return ptr;

        ComWrappers.TryGetComInstance(obj, out var unk);
        return unk;
    }

    public static void Release(System.Runtime.InteropServices.Marshalling.ComObject? obj) => ComExtensions.FinalRelease(obj);
    public static int Release(nint unk)
    {
        if (unk == 0)
            return 0;

        return Marshal.Release(unk);
    }

    public static void WithComInstance(object? obj, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        var unk = ToComInstance(obj);
        try
        {
            action(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static T WithComInstance<T>(object? obj, Func<nint, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        var unk = ToComInstance(obj);
        try
        {
            return func(unk);
        }
        finally
        {
            Release(unk);
        }
    }

    public static void WithComInstanceOfType<T>(T? obj, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk != 0)
        {
            var iid = typeof(T).GUID;
            _ = Marshal.QueryInterface(unk, ref iid, out iface);
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

    public static T WithComInstanceOfType<T, Ti>(object? obj, Func<nint, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        nint iface = 0;
        var unk = ToComInstance(obj);
        if (unk != 0)
        {
            var iid = typeof(Ti).GUID;
            _ = Marshal.QueryInterface(unk, ref iid, out iface);
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

    public static void WithComInstancesOfType<T>(T[]? array, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (array == null)
        {
            action(0);
            return;
        }

        var pointers = new nint[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            nint iface = 0;
            var unk = ToComInstance(array[i]);
            if (unk != 0)
            {
                var iid = typeof(T).GUID;
                _ = Marshal.QueryInterface(unk, ref iid, out iface);
                Marshal.Release(unk);
            }
            pointers[i] = iface;
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

    public static T WithComInstancesOfType<T, Ti>(Ti[]? array, Func<nint, T> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (array == null)
            return action(0);

        var pointers = new nint[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            nint iface = 0;
            var unk = ToComInstance(array[i]);
            if (unk != 0)
            {
                var iid = typeof(Ti).GUID;
                _ = Marshal.QueryInterface(unk, ref iid, out iface);
                Marshal.Release(unk);
            }
            pointers[i] = iface;
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
        if (disposing && _releaseOnDispose)
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
    public new T Object => (T)(object)base.Object;
    public override Type InterfaceType => typeof(T);

    public static IComObject<T>? CoCreate(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, nint outer = 0, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool throwOnError = true) => CoCreate<T>(classId, ctx, outer, flags, throwOnError);
}
