#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-impeg2componenttype
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2c073d84-b51c-48c9-aa9f-68971e1f6e38")]
public partial interface IMPEG2ComponentType : ILanguageComponentType
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2componenttype-get_streamtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StreamType(out MPEG2StreamType MP2StreamType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2componenttype-put_streamtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StreamType(MPEG2StreamType MP2StreamType);
}
