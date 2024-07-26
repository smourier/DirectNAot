namespace DirectN.Extensions;

public static class IDXGIObjectExtensions
{
    public static void SetDebugObjectName(this IComObject<IDXGIObject> child, [CallerArgumentExpression(nameof(child))] string? name = null) => SetDebugObjectName(child?.Object!, name);
    public static void SetDebugObjectName(this IDXGIObject child, [CallerArgumentExpression(nameof(child))] string? name = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(null, nameof(name));

        _ = child.SetPrivateData(Constants.WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), PWSTR.From(name).Value).ThrowOnError();
    }

    public static string? GetDebugObjectName(this IComObject<IDXGIObject> obj) => GetDebugObjectName(obj?.Object!);
    public static string? GetDebugObjectName(this IDXGIObject obj) => GetPrivateStringW(obj, Constants.WKPDID_D3DDebugObjectNameW).Nullify() ?? GetPrivateStringA(obj, Constants.WKPDID_D3DDebugObjectName).Nullify() ?? GetPrivateStringW(obj, Constants.WKPDID_D3DAutoDebugObjectNameW).Nullify();

    public static string? GetPrivateStringW(this IComObject<IDXGIObject> obj, Guid guid) => GetPrivateStringW(obj?.Object!, guid);
    public static string? GetPrivateStringW(this IDXGIObject obj, Guid guid)
    {
        ArgumentNullException.ThrowIfNull(obj);
        uint size = 0;
        if (obj.GetPrivateData(guid, ref size, 0).IsError)
            return null;

        if (size == 0)
            return string.Empty;

        using var p = new AllocPwstr(size);
        obj.GetPrivateData(guid, ref size, p.Value).ThrowOnError();
        return p.ToString();
    }

    public static string? GetPrivateStringA(this IComObject<IDXGIObject> obj, Guid guid) => GetPrivateStringA(obj?.Object!, guid);
    public static string? GetPrivateStringA(this IDXGIObject obj, Guid guid)
    {
        ArgumentNullException.ThrowIfNull(obj);
        uint size = 0;
        if (obj.GetPrivateData(guid, ref size, 0).IsError)
            return null;

        if (size == 0)
            return string.Empty;

        using var p = new AllocPstr(size);
        obj.GetPrivateData(guid, ref size, p.Value).ThrowOnError();
        return p.ToString();
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
