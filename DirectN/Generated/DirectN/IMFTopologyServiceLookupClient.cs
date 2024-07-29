#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imftopologyservicelookupclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fa99388a-4383-415a-a930-dd472a8cf6f7")]
public partial interface IMFTopologyServiceLookupClient
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imftopologyservicelookupclient-initservicepointers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitServicePointers(IMFTopologyServiceLookup pLookup);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imftopologyservicelookupclient-releaseservicepointers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseServicePointers();
}
