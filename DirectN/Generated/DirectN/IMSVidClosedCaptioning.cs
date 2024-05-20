#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidclosedcaptioning
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("99652ea1-c1f7-414f-bb7b-1c967de75983")]
public partial interface IMSVidClosedCaptioning : IMSVidFeature
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidclosedcaptioning-get_enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enable(out VARIANT_BOOL On);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidclosedcaptioning-put_enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enable(VARIANT_BOOL On);
}
