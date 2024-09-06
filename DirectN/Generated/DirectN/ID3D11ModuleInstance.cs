#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11moduleinstance
[GeneratedComInterface, Guid("469e07f7-045a-48d5-aa12-68a478cdf75d")]
public partial interface ID3D11ModuleInstance
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindconstantbufferbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindConstantBufferByName(PSTR pName, uint uDstSlot, uint cbDstOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindResource(uint uSrcSlot, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindresourcebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindResourceByName(PSTR pName, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindsampler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindsamplerbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindSamplerByName(PSTR pName, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindunorderedaccessview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindunorderedaccessviewbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindUnorderedAccessViewByName(PSTR pName, uint uDstSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindresourceasunorderedaccessview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11moduleinstance-bindresourceasunorderedaccessviewbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindResourceAsUnorderedAccessViewByName(PSTR pSrvName, uint uDstUavSlot, uint uCount);
}
