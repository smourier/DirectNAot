#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("02ca073c-7079-4860-880a-c2f7a449c991")]
public partial interface IHostControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHostManager(in Guid riid, out nint ppObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppDomainManager(uint dwAppDomainID, nint pUnkAppDomainManager);
}
