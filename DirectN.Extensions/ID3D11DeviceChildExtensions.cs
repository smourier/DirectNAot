namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class ID3D11DeviceChildExtensions
{
    public static void SetDebugObjectName(this IComObject<ID3D11DeviceChild> child, [CallerArgumentExpression(nameof(child))] string? name = null) => SetDebugObjectName(child?.Object!, name);
    public static void SetDebugObjectName(this ID3D11DeviceChild child, [CallerArgumentExpression(nameof(child))] string? name = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(null, nameof(name));

        _ = child.SetPrivateData(Constants.WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), PWSTR.From(name).Value).ThrowOnError();
    }

    public static string? GetDebugObjectName(this IComObject<ID3D11DeviceChild> obj) => GetDebugObjectName(obj?.Object!);
    public static string? GetDebugObjectName(this ID3D11DeviceChild obj) => GetPrivateStringW(obj, Constants.WKPDID_D3DDebugObjectNameW).Nullify() ?? GetPrivateStringA(obj, Constants.WKPDID_D3DDebugObjectName).Nullify() ?? GetPrivateStringW(obj, Constants.WKPDID_D3DAutoDebugObjectNameW).Nullify();

    public static string? GetPrivateStringW(this IComObject<ID3D11DeviceChild> obj, Guid guid) => GetPrivateStringW(obj?.Object!, guid);
    public static string? GetPrivateStringW(this ID3D11DeviceChild obj, Guid guid)
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

    public static string? GetPrivateStringA(this IComObject<ID3D11DeviceChild> obj, Guid guid) => GetPrivateStringA(obj?.Object!, guid);
    public static string? GetPrivateStringA(this ID3D11DeviceChild obj, Guid guid)
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
}
