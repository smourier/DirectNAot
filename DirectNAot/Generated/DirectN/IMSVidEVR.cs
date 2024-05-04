#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidevr
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("15e496ae-82a8-4cf9-a6b6-c561dc60398f")]
public partial interface IMSVidEVR : IMSVidVideoRenderer
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidevr-get_presenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Presenter(out IMFVideoPresenter ppAllocPresent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidevr-put_presenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Presenter(IMFVideoPresenter pAllocPresent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidevr-put_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SuppressEffects(VARIANT_BOOL bSuppress);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidevr-get_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SuppressEffects(out VARIANT_BOOL bSuppress);
}
