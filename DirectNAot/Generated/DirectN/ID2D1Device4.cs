#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1device4
[GeneratedComInterface, Guid("d7bdb159-5683-4a46-bc9c-72dc720b858b")]
public partial interface ID2D1Device4 : ID2D1Device3
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device4-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, out ID2D1DeviceContext4 deviceContext4);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device4-setmaximumcolorglyphcachememory
    [PreserveSig]
    void SetMaximumColorGlyphCacheMemory(ulong maximumInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device4-getmaximumcolorglyphcachememory
    [PreserveSig]
    ulong GetMaximumColorGlyphCacheMemory();
}
