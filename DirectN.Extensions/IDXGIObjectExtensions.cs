namespace DirectN;

public static class IDXGIObjectExtensions
{
    public static void SetDebugObjectName(this IComObject<IDXGIObject> child, string name) => SetDebugObjectName(child?.Object!, name);
    public static void SetDebugObjectName(this IDXGIObject child, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(null, nameof(name));

        _ = child.SetPrivateData(Constants.WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), PWSTR.From(name).Value).ThrowOnError();
    }

    public static void SetPrivateData(this IComObject<IDXGIObject> obj, Guid guid, uint dataSize, nint data) => SetPrivateData(obj?.Object!, guid, dataSize, data);
    public static void SetPrivateData(this IDXGIObject obj, Guid guid, uint dataSize, nint data)
    {
        obj.SetPrivateData(guid, dataSize, data).ThrowOnError();
    }

    public static void SetPrivateDataInterface(this IComObject<IDXGIObject> obj, Guid guid, nint data) => SetPrivateDataInterface(obj?.Object!, guid, data);
    public static void SetPrivateDataInterface(this IDXGIObject obj, Guid guid, nint data)
    {
        obj.SetPrivateDataInterface(guid, data).ThrowOnError();
    }

    public static IComObject<T> GetParent<T>(this IDXGIObject obj)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.GetParent(typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }
}
