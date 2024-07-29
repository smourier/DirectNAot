#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamoverlayfx
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("62fae250-7e65-4460-bfc9-6398b322073c")]
public partial interface IAMOverlayFX
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamoverlayfx-queryoverlayfxcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryOverlayFXCaps(out uint lpdwOverlayFXCaps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamoverlayfx-setoverlayfx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOverlayFX(uint dwOverlayFX);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamoverlayfx-getoverlayfx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlayFX(out uint lpdwOverlayFX);
}
