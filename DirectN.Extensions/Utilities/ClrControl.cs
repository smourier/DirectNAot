namespace DirectN.Extensions.Utilities;

public sealed class ClrControl(IComObject<ICLRControl>? comObject)
    : InterlockedComObject<ICLRControl>(comObject)
{
    public HRESULT SetAppDomainManagerType(string assembly, string type, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        ArgumentNullException.ThrowIfNull(type);
        return ComObject.Object.SetAppDomainManagerType(new Pwstr(assembly), new Pwstr(type)).ThrowOnError(throwOnError);
    }

    public IComObject<T>? GetCLRManager<T>(CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true)
    {
        ComObject.Object.GetCLRManager(typeof(T).GUID, out var ptr);
        if (ptr == 0)
            return default;

        return Com.ComObject.FromPointer<T>(ptr, flags, releaseOnDispose);
    }

    public nint GetCLRManager(Guid iid, bool throwOnError = true)
    {
        ComObject.Object.GetCLRManager(iid, out var ptr).ThrowOnError(throwOnError);
        return ptr;
    }
}
