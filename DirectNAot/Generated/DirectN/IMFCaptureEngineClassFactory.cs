#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcaptureengineclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("8f02d140-56fc-4302-a705-3a97c78be779")]
public partial interface IMFCaptureEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengineclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(in Guid clsid, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvObject);
}
