#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidencoder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c0020fd4-bee7-43d9-a495-9f213117103d")]
public partial interface IMSVidEncoder : IMSVidFeature
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidencoder-get_videoencoderinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoEncoderInterface(out nint ppEncInt);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidencoder-get_audioencoderinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioEncoderInterface(out nint ppEncInt);
}
