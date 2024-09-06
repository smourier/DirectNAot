#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-impeg2demultiplexer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("436eee9c-264f-4242-90e1-4e330c107512")]
public partial interface IMpeg2Demultiplexer
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2demultiplexer-createoutputpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateOutputPin(in AM_MEDIA_TYPE pMediaType, PWSTR pszPinName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] out IPin ppIPin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2demultiplexer-setoutputpinmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputPinMediaType(PWSTR pszPinName, in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2demultiplexer-deleteoutputpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteOutputPin(PWSTR pszPinName);
}
