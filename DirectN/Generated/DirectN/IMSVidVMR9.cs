#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvmr9
[GeneratedComInterface, Guid("d58b0015-ebef-44bb-bbdd-3f3699d76ea1")]
public partial interface IMSVidVMR9 : IMSVidVideoRenderer
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvmr9-get_allocator_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Allocator_ID(out int ID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvmr9-setallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocator(nint AllocPresent, int ID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvmr9-put_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SuppressEffects(VARIANT_BOOL bSuppress);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvmr9-get_suppresseffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SuppressEffects(out VARIANT_BOOL bSuppress);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvmr9-get_allocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Allocator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint AllocPresent);
}
