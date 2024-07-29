#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iregisterserviceprovider
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7b3a2f01-0751-48dd-b556-004785171c54")]
public partial interface IRegisterServiceProvider
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iregisterserviceprovider-registerservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterService(in Guid guidService, nint pUnkObject);
}
