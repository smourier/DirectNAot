namespace DirectN;

[SupportedOSPlatform("windows6.0.6000")]
public static class IMFActivateExtensions
{
    public static IComObject<T>? ActivateObject<T>(this IComObject<IMFActivate> obj, bool throwOnError = true) => ActivateObject<T>(obj?.Object!, typeof(T).GUID, throwOnError);
    public static IComObject<T>? ActivateObject<T>(this IComObject<IMFActivate> obj, Guid riid, bool throwOnError = true) => ActivateObject<T>(obj?.Object!, riid, throwOnError);
    public static IComObject<T>? ActivateObject<T>(this IMFActivate obj, bool throwOnError = true) => ActivateObject<T>(obj, typeof(T).GUID, throwOnError);
    public static IComObject<T>? ActivateObject<T>(this IMFActivate obj, Guid riid, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.ActivateObject(riid, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return null;

        return ComObject.FromPointer<T>(unk);
    }

    public static void ShutdownObject(this IComObject<IMFActivate> obj, bool throwOnError = true) => ShutdownObject(obj?.Object!, throwOnError);
    public static void ShutdownObject(this IMFActivate obj, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.ShutdownObject().ThrowOnError(throwOnError);
    }

    public static void DetachObject(this IComObject<IMFActivate> obj, bool throwOnError = true) => DetachObject(obj?.Object!, throwOnError);
    public static void DetachObject(this IMFActivate obj, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.DetachObject().ThrowOnError(throwOnError);
    }
}
