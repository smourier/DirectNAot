#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-impeg2tunerequestfactory
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("14e11abd-ee37-4893-9ea1-6964de933e39")]
public partial interface IMPEG2TuneRequestFactory : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2tunerequestfactory-createtunerequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTuneRequest(ITuningSpace TuningSpace, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMPEG2TuneRequest>))] out IMPEG2TuneRequest TuneRequest);
}
