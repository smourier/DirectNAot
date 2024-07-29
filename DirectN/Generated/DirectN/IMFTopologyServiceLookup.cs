#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imftopologyservicelookup
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fa993889-4383-415a-a930-dd472a8cf6f7")]
public partial interface IMFTopologyServiceLookup
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imftopologyservicelookup-lookupservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LookupService(MF_SERVICE_LOOKUP_TYPE Type, uint dwIndex, in Guid guidService, in Guid riid, out nint ppvObjects, ref uint pnObjects);
}
