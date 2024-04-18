namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11devicecontext
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
public partial interface ID3D11DeviceContext : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetconstantbuffers
    [PreserveSig]
    public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetshaderresources
    [PreserveSig]
    public void PSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetshader
    [PreserveSig]
    public void PSSetShader(ID3D11PixelShader pPixelShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetsamplers
    [PreserveSig]
    public void PSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetshader
    [PreserveSig]
    public void VSSetShader(ID3D11VertexShader pVertexShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexed
    [PreserveSig]
    public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-draw
    [PreserveSig]
    public void Draw(uint VertexCount, uint StartVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Map(ID3D11Resource pResource, uint Subresource, D3D11_MAP MapType, uint MapFlags, nint/* nint */ pMappedResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-unmap
    [PreserveSig]
    public void Unmap(ID3D11Resource pResource, uint Subresource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetconstantbuffers
    [PreserveSig]
    public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetinputlayout
    [PreserveSig]
    public void IASetInputLayout(ID3D11InputLayout pInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetvertexbuffers
    [PreserveSig]
    public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppVertexBuffers, nint/* nint */ pStrides, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetindexbuffer
    [PreserveSig]
    public void IASetIndexBuffer(ID3D11Buffer pIndexBuffer, DXGI_FORMAT Format, uint Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexedinstanced
    [PreserveSig]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawinstanced
    [PreserveSig]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetconstantbuffers
    [PreserveSig]
    public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetshader
    [PreserveSig]
    public void GSSetShader(ID3D11GeometryShader pShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetprimitivetopology
    [PreserveSig]
    public void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY Topology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetshaderresources
    [PreserveSig]
    public void VSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetsamplers
    [PreserveSig]
    public void VSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-begin
    [PreserveSig]
    public void Begin(ID3D11Asynchronous pAsync);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-end
    [PreserveSig]
    public void End(ID3D11Asynchronous pAsync);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetData(ID3D11Asynchronous pAsync, nint/* nint */ pData, uint DataSize, uint GetDataFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-setpredication
    [PreserveSig]
    public void SetPredication(ID3D11Predicate pPredicate, [MarshalAs(UnmanagedType.U4)] bool PredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetshaderresources
    [PreserveSig]
    public void GSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetsamplers
    [PreserveSig]
    public void GSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetrendertargets
    [PreserveSig]
    public void OMSetRenderTargets(uint NumViews, nint/* nint */ ppRenderTargetViews, ID3D11DepthStencilView pDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetrendertargetsandunorderedaccessviews
    [PreserveSig]
    public void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, nint/* nint */ ppRenderTargetViews, ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, nint/* nint */ ppUnorderedAccessViews, nint/* nint */ pUAVInitialCounts);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetblendstate
    [PreserveSig]
    public void OMSetBlendState(ID3D11BlendState pBlendState, nint/* nint */ BlendFactor, uint SampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetdepthstencilstate
    [PreserveSig]
    public void OMSetDepthStencilState(ID3D11DepthStencilState pDepthStencilState, uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-sosettargets
    [PreserveSig]
    public void SOSetTargets(uint NumBuffers, nint/* nint */ ppSOTargets, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawauto
    [PreserveSig]
    public void DrawAuto();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexedinstancedindirect
    [PreserveSig]
    public void DrawIndexedInstancedIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawinstancedindirect
    [PreserveSig]
    public void DrawInstancedIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dispatch
    [PreserveSig]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dispatchindirect
    [PreserveSig]
    public void DispatchIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetstate
    [PreserveSig]
    public void RSSetState(ID3D11RasterizerState pRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetviewports
    [PreserveSig]
    public void RSSetViewports(uint NumViewports, nint/* nint */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetscissorrects
    [PreserveSig]
    public void RSSetScissorRects(uint NumRects, nint/* nint */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copysubresourceregion
    [PreserveSig]
    public void CopySubresourceRegion(ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource pSrcResource, uint SrcSubresource, nint/* nint */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copyresource
    [PreserveSig]
    public void CopyResource(ID3D11Resource pDstResource, ID3D11Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-updatesubresource
    [PreserveSig]
    public void UpdateSubresource(ID3D11Resource pDstResource, uint DstSubresource, nint/* nint */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copystructurecount
    [PreserveSig]
    public void CopyStructureCount(ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView pSrcView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearrendertargetview
    [PreserveSig]
    public void ClearRenderTargetView(ID3D11RenderTargetView pRenderTargetView, in float ColorRGBA);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearunorderedaccessviewuint
    [PreserveSig]
    public void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView pUnorderedAccessView, in uint Values);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearunorderedaccessviewfloat
    [PreserveSig]
    public void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView pUnorderedAccessView, in float Values);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cleardepthstencilview
    [PreserveSig]
    public void ClearDepthStencilView(ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-generatemips
    [PreserveSig]
    public void GenerateMips(ID3D11ShaderResourceView pShaderResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-setresourceminlod
    [PreserveSig]
    public void SetResourceMinLOD(ID3D11Resource pResource, float MinLOD);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getresourceminlod
    [PreserveSig]
    public float GetResourceMinLOD(ID3D11Resource pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-resolvesubresource
    [PreserveSig]
    public void ResolveSubresource(ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-executecommandlist
    [PreserveSig]
    public void ExecuteCommandList(ID3D11CommandList pCommandList, [MarshalAs(UnmanagedType.U4)] bool RestoreContextState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetshaderresources
    [PreserveSig]
    public void HSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetshader
    [PreserveSig]
    public void HSSetShader(ID3D11HullShader pHullShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetsamplers
    [PreserveSig]
    public void HSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetconstantbuffers
    [PreserveSig]
    public void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetshaderresources
    [PreserveSig]
    public void DSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetshader
    [PreserveSig]
    public void DSSetShader(ID3D11DomainShader pDomainShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetsamplers
    [PreserveSig]
    public void DSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetconstantbuffers
    [PreserveSig]
    public void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetshaderresources
    [PreserveSig]
    public void CSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetunorderedaccessviews
    [PreserveSig]
    public void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, nint/* nint */ ppUnorderedAccessViews, nint/* nint */ pUAVInitialCounts);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetshader
    [PreserveSig]
    public void CSSetShader(ID3D11ComputeShader pComputeShader, nint/* nint */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetsamplers
    [PreserveSig]
    public void CSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetconstantbuffers
    [PreserveSig]
    public void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetconstantbuffers
    [PreserveSig]
    public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetshaderresources
    [PreserveSig]
    public void PSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetshader
    [PreserveSig]
    public void PSGetShader(out ID3D11PixelShader ppPixelShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetsamplers
    [PreserveSig]
    public void PSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetshader
    [PreserveSig]
    public void VSGetShader(out ID3D11VertexShader ppVertexShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetconstantbuffers
    [PreserveSig]
    public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetinputlayout
    [PreserveSig]
    public void IAGetInputLayout(out ID3D11InputLayout ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetvertexbuffers
    [PreserveSig]
    public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppVertexBuffers, nint/* nint */ pStrides, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetindexbuffer
    [PreserveSig]
    public void IAGetIndexBuffer(nint/* nint */ pIndexBuffer, nint/* nint */ Format, nint/* nint */ Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetconstantbuffers
    [PreserveSig]
    public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetshader
    [PreserveSig]
    public void GSGetShader(out ID3D11GeometryShader ppGeometryShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetprimitivetopology
    [PreserveSig]
    public void IAGetPrimitiveTopology(out D3D_PRIMITIVE_TOPOLOGY pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetshaderresources
    [PreserveSig]
    public void VSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetsamplers
    [PreserveSig]
    public void VSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getpredication
    [PreserveSig]
    public void GetPredication(nint/* nint */ ppPredicate, nint/* nint */ pPredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetshaderresources
    [PreserveSig]
    public void GSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetsamplers
    [PreserveSig]
    public void GSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetrendertargets
    [PreserveSig]
    public void OMGetRenderTargets(uint NumViews, nint/* nint */ ppRenderTargetViews, nint/* nint */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetrendertargetsandunorderedaccessviews
    [PreserveSig]
    public void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, nint/* nint */ ppRenderTargetViews, nint/* nint */ ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, nint/* nint */ ppUnorderedAccessViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetblendstate
    [PreserveSig]
    public void OMGetBlendState(nint/* nint */ ppBlendState, nint/* nint */ BlendFactor, nint/* nint */ pSampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetdepthstencilstate
    [PreserveSig]
    public void OMGetDepthStencilState(nint/* nint */ ppDepthStencilState, nint/* nint */ pStencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-sogettargets
    [PreserveSig]
    public void SOGetTargets(uint NumBuffers, nint/* nint */ ppSOTargets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetstate
    [PreserveSig]
    public void RSGetState(out ID3D11RasterizerState ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetviewports
    [PreserveSig]
    public void RSGetViewports(ref uint pNumViewports, nint/* nint */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetscissorrects
    [PreserveSig]
    public void RSGetScissorRects(ref uint pNumRects, nint/* nint */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetshaderresources
    [PreserveSig]
    public void HSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetshader
    [PreserveSig]
    public void HSGetShader(out ID3D11HullShader ppHullShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetsamplers
    [PreserveSig]
    public void HSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetconstantbuffers
    [PreserveSig]
    public void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetshaderresources
    [PreserveSig]
    public void DSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetshader
    [PreserveSig]
    public void DSGetShader(out ID3D11DomainShader ppDomainShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetsamplers
    [PreserveSig]
    public void DSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetconstantbuffers
    [PreserveSig]
    public void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetshaderresources
    [PreserveSig]
    public void CSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetunorderedaccessviews
    [PreserveSig]
    public void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, nint/* nint */ ppUnorderedAccessViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetshader
    [PreserveSig]
    public void CSGetShader(out ID3D11ComputeShader ppComputeShader, nint/* nint */ ppClassInstances, nint/* nint */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetsamplers
    [PreserveSig]
    public void CSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetconstantbuffers
    [PreserveSig]
    public void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearstate
    [PreserveSig]
    public void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-flush
    [PreserveSig]
    public void Flush();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gettype
    [PreserveSig]
    public D3D11_DEVICE_CONTEXT_TYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getcontextflags
    [PreserveSig]
    public uint GetContextFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-finishcommandlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FinishCommandList([MarshalAs(UnmanagedType.U4)] bool RestoreDeferredContextState, nint/* nint */ ppCommandList);
}
