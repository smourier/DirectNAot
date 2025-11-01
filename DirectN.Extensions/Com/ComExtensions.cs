namespace DirectN.Extensions.Com;

public static class ComExtensions
{
    public static void FinalRelease(this object? comObject)
    {
        if (comObject == null)
            return;

        // note: only works on unique instance objects
        var co = (System.Runtime.InteropServices.Marshalling.ComObject)comObject;
        co.FinalRelease();

        if (Environment.Version.Major < 9)
        {
            // this hack is to overcome a dreadful bug in .NET 8 https://github.com/dotnet/runtime/issues/96901
            // we want only unique objects but the system currently totally fails at supporting this
            SafeIUnknown.Patch(co);
        }
    }

    private partial class SafeIUnknown
    {
        private static readonly SafeIUnknown _instance = new();
        private static readonly FieldInfo? _pointerField = typeof(System.Runtime.InteropServices.Marshalling.ComObject).GetField("_instancePointer", BindingFlags.NonPublic | BindingFlags.Instance);
        private static readonly PropertyInfo? _uniqueInstanceField = typeof(System.Runtime.InteropServices.Marshalling.ComObject).GetProperty("UniqueInstance", BindingFlags.NonPublic | BindingFlags.Instance);
        private static readonly nint _unk = ComObject.ComWrappers.GetOrCreateComInterfaceForObject(_instance, CreateComInterfaceFlags.None);

        // old version that crashes https://github.com/dotnet/runtime/blob/1dedddef7b8f389e3720b9c643306b98b092ad87/src/libraries/System.Runtime.InteropServices/src/System/Runtime/InteropServices/Marshalling/ComObject.cs#L78
        public static void Patch(System.Runtime.InteropServices.Marshalling.ComObject obj)
        {
            if (obj == null || _pointerField == null || _uniqueInstanceField == null)
                return;

            if (!(bool)_uniqueInstanceField.GetValue(obj)!)
                return;

            _pointerField.SetValue(obj, _unk);
        }
    }

    public static void SafeDispose(this IComObject? comObject)
    {
        if (comObject == null || comObject.IsDisposed)
            return;

        comObject.Dispose();
    }

    public static IComObject<T>? As<T>(this IComObject? comObject, bool releaseOnDispose = false, bool throwOnError = false)
    {
        if (comObject == null)
            return null;

        if (comObject is IComObject<T> co)
            return co;

        if (comObject.Object is T t)
            return new ComObject<T>(t, releaseOnDispose);

        if (throwOnError)
            throw new InvalidCastException($"Cannot cast COM object of type '{comObject.InterfaceType}' to '{typeof(T)}'.");

        return default;
    }

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static IEnumerable<T?>? Unwrap<T>(this IEnumerable<IComObject<T>?>? enumerable) => enumerable?.Select(e => e is null ? default : e.Object);

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static T?[]? UnwrapAsArray<T>(this IEnumerable<IComObject<T>?>? enumerable) => enumerable?.Select(e => e is null ? default : e.Object)?.ToArray();

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static nint[]? GetOrCreateComInstances<T>(this IEnumerable<IComObject<T>?>? enumerable, CreateComInterfaceFlags flags = CreateComInterfaceFlags.None, bool throwOnError = false) => enumerable?.Select(e => e is null ? 0 : ComObject.GetOrCreateComInstance(e, flags, throwOnError)).ToArray();

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static IEnumerable<IComObject<T>>? ToComObjects<T>(this IEnumerable<T>? enumerable) => enumerable?.Where(e => e != null).Select(e => new ComObject<T>(e!));

    public static IComObject<T> Clone<T>(this IComObject<T>? comObject, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        ObjectDisposedException.ThrowIf(comObject.IsDisposed, nameof(comObject));
        return WithAddRef(comObject, unk => ComObject.FromPointer<T>(unk, flags, releaseOnDispose))!;
    }

    // comObject is not null, this is just to be consistent with IComObject.AddRef(), so we can write:
    //
    // var unk = comObject.AddRef()
    // ...
    // comObject.Release(unk)
    //
    public static int Release(this IComObject? comObject, nint unk)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        if (unk == 0)
            return -1;

        return Marshal.Release(unk);
    }

    public static void WithAddRef(this IComObject comObject, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        ArgumentNullException.ThrowIfNull(action);
        var unk = comObject.AddRef();
        try
        {
            action(unk);
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static T WithAddRef<T>(this IComObject comObject, Func<nint, T> func)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        ArgumentNullException.ThrowIfNull(func);
        var unk = comObject.AddRef();
        try
        {
            return func(unk);
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static async Task WithAddRef<T>(this IComObject comObject, Func<nint, Task> action)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        ArgumentNullException.ThrowIfNull(action);
        var unk = comObject.AddRef();
        try
        {
            await action(unk);
        }
        finally
        {
            Marshal.Release(unk);
        }
    }

    public static async Task<T> WithAddRef<T>(this IComObject comObject, Func<nint, Task<T>> action)
    {
        ArgumentNullException.ThrowIfNull(comObject);
        ArgumentNullException.ThrowIfNull(action);
        var unk = comObject.AddRef();
        try
        {
            return await action(unk);
        }
        finally
        {
            Marshal.Release(unk);
        }
    }
}
