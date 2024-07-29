#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbservicedescriptor2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d6c76506-85ab-487c-9b2b-36416511e4a2")]
public partial interface IDvbServiceDescriptor2 : IDvbServiceDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbservicedescriptor2-getserviceprovidernamew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceProviderNameW(DVB_STRCONV_MODE convMode, out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbservicedescriptor2-getservicenamew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceNameW(DVB_STRCONV_MODE convMode, out BSTR pbstrName);
}
