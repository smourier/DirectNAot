#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nn-windows-graphics-holographic-interop-iholographiccamerainterop
[GeneratedComInterface, Guid("7cc1f9c5-6d02-41fa-9500-e1809eb48eec")]
public partial interface IHolographicCameraInterop : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerainterop-createdirect3d12backbufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDirect3D12BackBufferResource(ID3D12Device pDevice, in D3D12_RESOURCE_DESC pTexture2DDesc, out ID3D12Resource ppCreatedTexture2DResource);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerainterop-createdirect3d12hardwareprotectedbackbufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDirect3D12HardwareProtectedBackBufferResource(ID3D12Device pDevice, in D3D12_RESOURCE_DESC pTexture2DDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out ID3D12Resource ppCreatedTexture2DResource);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerainterop-acquiredirect3d12bufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireDirect3D12BufferResource(ID3D12Resource pResourceToAcquire, ID3D12CommandQueue pCommandQueue);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerainterop-acquiredirect3d12bufferresourcewithtimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireDirect3D12BufferResourceWithTimeout(ID3D12Resource pResourceToAcquire, ID3D12CommandQueue pCommandQueue, ulong duration);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographiccamerainterop-unacquiredirect3d12bufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnacquireDirect3D12BufferResource(ID3D12Resource pResourceToUnacquire);
}
