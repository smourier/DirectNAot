#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturesink2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f9e4219e-6197-4b5e-b888-bee310ab2c59")]
public partial interface IMFCaptureSink2 : IMFCaptureSink
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink2-setoutputmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputMediaType(uint dwStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pEncodingAttributes);
}
