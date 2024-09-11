#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcaptureengineonsamplecallback
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("52150b82-ab39-4467-980f-e48bf0822ecd")]
public partial interface IMFCaptureEngineOnSampleCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengineonsamplecallback-onsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample?>))] IMFSample? pSample);
}
