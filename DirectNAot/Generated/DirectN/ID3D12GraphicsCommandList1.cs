namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist1
[GeneratedComInterface, Guid("553103fb-1fe7-4557-bb38-946d7d0e7ca7")]
public partial interface ID3D12GraphicsCommandList1 : ID3D12GraphicsCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-atomiccopybufferuint
    [PreserveSig]
    public void AtomicCopyBufferUINT(ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, in ID3D12Resource ppDependentResources, in D3D12_SUBRESOURCE_RANGE_UINT64 pDependentSubresourceRanges);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-atomiccopybufferuint64
    [PreserveSig]
    public void AtomicCopyBufferUINT64(ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, in ID3D12Resource ppDependentResources, in D3D12_SUBRESOURCE_RANGE_UINT64 pDependentSubresourceRanges);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-omsetdepthbounds
    [PreserveSig]
    public void OMSetDepthBounds(float Min, float Max);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-setsamplepositions
    [PreserveSig]
    public void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, in D3D12_SAMPLE_POSITION pSamplePositions);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-resolvesubresourceregion
    [PreserveSig]
    public void ResolveSubresourceRegion(ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource pSrcResource, uint SrcSubresource, nint/* nint */ pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist1-setviewinstancemask
    [PreserveSig]
    public void SetViewInstanceMask(uint Mask);
}
