﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nn-windows-graphics-holographic-interop-iholographicquadlayerinterop
[GeneratedComInterface, Guid("cfa688f0-639e-4a47-83d7-6b7f5ebf7fed")]
public partial interface IHolographicQuadLayerInterop : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerinterop-createdirect3d12contentbufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDirect3D12ContentBufferResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Device>))] ID3D12Device pDevice, in D3D12_RESOURCE_DESC pTexture2DDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] out ID3D12Resource ppTexture2DResource);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerinterop-createdirect3d12hardwareprotectedcontentbufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDirect3D12HardwareProtectedContentBufferResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Device>))] ID3D12Device pDevice, in D3D12_RESOURCE_DESC pTexture2DDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12ProtectedResourceSession>))] ID3D12ProtectedResourceSession pProtectedResourceSession, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] out ID3D12Resource ppCreatedTexture2DResource);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerinterop-acquiredirect3d12bufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireDirect3D12BufferResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResourceToAcquire, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandQueue>))] ID3D12CommandQueue pCommandQueue);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerinterop-acquiredirect3d12bufferresourcewithtimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireDirect3D12BufferResourceWithTimeout([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResourceToAcquire, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandQueue>))] ID3D12CommandQueue pCommandQueue, ulong duration);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.holographic.interop/nf-windows-graphics-holographic-interop-iholographicquadlayerinterop-unacquiredirect3d12bufferresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnacquireDirect3D12BufferResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResourceToUnacquire);
}
