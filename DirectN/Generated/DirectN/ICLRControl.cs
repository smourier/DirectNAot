#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9065597e-d1a1-4fb2-b6ba-7e1fce230f61")]
public partial interface ICLRControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCLRManager(in Guid riid, out nint ppObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppDomainManagerType(PWSTR pwzAppDomainManagerAssembly, PWSTR pwzAppDomainManagerType);
}
