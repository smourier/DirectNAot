namespace DirectN.Extensions.Com;

public static class ComExtensions
{
    public static void FinalRelease(this object? comObject)
    {
        if (comObject == null)
            return;

        // note: only works on unique instance objects
        ((System.Runtime.InteropServices.Marshalling.ComObject)comObject).FinalRelease();
    }

    public static void SafeDispose(this IComObject? comObject)
    {
        if (comObject == null || comObject.IsDisposed)
            return;

        comObject.Dispose();
    }

    public static IComObject<T>? As<T>(this IComObject? comObject, bool releaseOnDispose = false)
    {
        if (comObject == null)
            return null;

        if (comObject.Object is T t)
            return new ComObject<T>(t, releaseOnDispose);

        return default;
    }

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static IEnumerable<T>? Unwrap<T>(this IEnumerable<IComObject<T>>? enumerable) => enumerable?.Select(e => e.Object);

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static T[]? UnwrapAsArray<T>(this IEnumerable<IComObject<T>>? enumerable) => enumerable?.Select(e => e.Object)?.ToArray();

    [return: NotNullIfNotNull(nameof(enumerable))]
    public static IEnumerable<IComObject<T>>? ToComObjects<T>(this IEnumerable<T>? enumerable) => enumerable?.Select(e => new ComObject<T>(e));

    public static void WithAllocatedMemory(uint size, Action<nint> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (size == 0)
        {
            action(0);
            return;
        }

        var ptr = Marshal.AllocCoTaskMem((int)size);
        try
        {
            action(ptr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

    public static T WithAllocatedMemory<T>(uint size, Func<nint, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (size == 0)
            return func(0);

        var ptr = Marshal.AllocCoTaskMem((int)size);
        try
        {
            return func(ptr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }
}
