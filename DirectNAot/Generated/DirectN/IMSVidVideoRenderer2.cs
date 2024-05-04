#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvideorenderer2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6bdd5c1e-2810-4159-94bc-05511ae8549b")]
public partial interface IMSVidVideoRenderer2 : IMSVidVideoRenderer
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-get_allocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Allocator(out nint AllocPresent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-get__allocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__Allocator(out IVMRSurfaceAllocator AllocPresent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-get_allocator_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Allocator_ID(out int ID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-setallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocator(nint AllocPresent, int ID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _SetAllocator2(IVMRSurfaceAllocator AllocPresent, int ID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-put_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SuppressEffects(VARIANT_BOOL bSuppress);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer2-get_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SuppressEffects(out VARIANT_BOOL bSuppress);
}
