#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/servprov/nn-servprov-iserviceprovider
[GeneratedComInterface, Guid("6d5140c1-7436-11ce-8034-00aa006009fa")]
public partial interface IServiceProvider
{
    // https://learn.microsoft.com/windows/win32/api/servprov/nf-servprov-iserviceprovider-queryservice(refguid_refiid_void)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryService(in Guid guidService, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvObject);
}
