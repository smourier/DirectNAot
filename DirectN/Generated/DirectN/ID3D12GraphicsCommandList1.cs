﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist1
[GeneratedComInterface, Guid("553103fb-1fe7-4557-bb38-946d7d0e7ca7")]
public partial interface ID3D12GraphicsCommandList1 : ID3D12GraphicsCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-atomiccopybufferuint
    [PreserveSig]
    void AtomicCopyBufferUINT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstBuffer, ulong DstOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, [In][MarshalUsing(CountElementName = nameof(Dependencies))] ID3D12Resource[] ppDependentResources, [In][MarshalUsing(CountElementName = nameof(Dependencies))] D3D12_SUBRESOURCE_RANGE_UINT64[] pDependentSubresourceRanges);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-atomiccopybufferuint64
    [PreserveSig]
    void AtomicCopyBufferUINT64([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstBuffer, ulong DstOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, [In][MarshalUsing(CountElementName = nameof(Dependencies))] ID3D12Resource[] ppDependentResources, [In][MarshalUsing(CountElementName = nameof(Dependencies))] D3D12_SUBRESOURCE_RANGE_UINT64[] pDependentSubresourceRanges);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-omsetdepthbounds
    [PreserveSig]
    void OMSetDepthBounds(float Min, float Max);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-setsamplepositions
    [PreserveSig]
    void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, in D3D12_SAMPLE_POSITION pSamplePositions);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-resolvesubresourceregion
    [PreserveSig]
    void ResolveSubresourceRegion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcResource, uint SrcSubresource, nint /* optional RECT* */ pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-setviewinstancemask
    [PreserveSig]
    void SetViewInstanceMask(uint Mask);
}
