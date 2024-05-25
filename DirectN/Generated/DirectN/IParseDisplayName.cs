#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iparsedisplayname
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000011a-0000-0000-c000-000000000046")]
public partial interface IParseDisplayName
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iparsedisplayname-parsedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseDisplayName(IBindCtx pbc, PWSTR pszDisplayName, out uint pchEaten, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkOut);
}
