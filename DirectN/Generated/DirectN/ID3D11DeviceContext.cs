#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11devicecontext
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
public partial interface ID3D11DeviceContext : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetconstantbuffers
    [PreserveSig]
    void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetshaderresources
    [PreserveSig]
    void PSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetshader
    [PreserveSig]
    void PSSetShader(ID3D11PixelShader? pPixelShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetsamplers
    [PreserveSig]
    void PSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetshader
    [PreserveSig]
    void VSSetShader(ID3D11VertexShader? pVertexShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexed
    [PreserveSig]
    void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-draw
    [PreserveSig]
    void Draw(uint VertexCount, uint StartVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(ID3D11Resource pResource, uint Subresource, D3D11_MAP MapType, uint MapFlags, nint /* optional D3D11_MAPPED_SUBRESOURCE* */ pMappedResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-unmap
    [PreserveSig]
    void Unmap(ID3D11Resource pResource, uint Subresource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-pssetconstantbuffers
    [PreserveSig]
    void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetinputlayout
    [PreserveSig]
    void IASetInputLayout(ID3D11InputLayout? pInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetvertexbuffers
    [PreserveSig]
    void IASetVertexBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppVertexBuffers, nint /* optional uint* */ pStrides, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetindexbuffer
    [PreserveSig]
    void IASetIndexBuffer(ID3D11Buffer? pIndexBuffer, DXGI_FORMAT Format, uint Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexedinstanced
    [PreserveSig]
    void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawinstanced
    [PreserveSig]
    void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetconstantbuffers
    [PreserveSig]
    void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetshader
    [PreserveSig]
    void GSSetShader(ID3D11GeometryShader? pShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iasetprimitivetopology
    [PreserveSig]
    void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY Topology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetshaderresources
    [PreserveSig]
    void VSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vssetsamplers
    [PreserveSig]
    void VSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-begin
    [PreserveSig]
    void Begin(ID3D11Asynchronous pAsync);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-end
    [PreserveSig]
    void End(ID3D11Asynchronous pAsync);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(ID3D11Asynchronous pAsync, nint /* optional void* */ pData, uint DataSize, uint GetDataFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-setpredication
    [PreserveSig]
    void SetPredication(ID3D11Predicate? pPredicate, BOOL PredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetshaderresources
    [PreserveSig]
    void GSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gssetsamplers
    [PreserveSig]
    void GSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetrendertargets
    [PreserveSig]
    void OMSetRenderTargets(uint NumViews, nint /* optional ID3D11RenderTargetView* */ ppRenderTargetViews, ID3D11DepthStencilView? pDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetrendertargetsandunorderedaccessviews
    [PreserveSig]
    void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, nint /* optional ID3D11RenderTargetView* */ ppRenderTargetViews, ID3D11DepthStencilView? pDepthStencilView, uint UAVStartSlot, uint NumUAVs, nint /* optional ID3D11UnorderedAccessView* */ ppUnorderedAccessViews, nint /* optional uint* */ pUAVInitialCounts);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetblendstate
    [PreserveSig]
    void OMSetBlendState(ID3D11BlendState? pBlendState, nint /* optional float* */ BlendFactor, uint SampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omsetdepthstencilstate
    [PreserveSig]
    void OMSetDepthStencilState(ID3D11DepthStencilState? pDepthStencilState, uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-sosettargets
    [PreserveSig]
    void SOSetTargets(uint NumBuffers, nint /* optional ID3D11Buffer* */ ppSOTargets, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawauto
    [PreserveSig]
    void DrawAuto();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawindexedinstancedindirect
    [PreserveSig]
    void DrawIndexedInstancedIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-drawinstancedindirect
    [PreserveSig]
    void DrawInstancedIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dispatch
    [PreserveSig]
    void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dispatchindirect
    [PreserveSig]
    void DispatchIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetstate
    [PreserveSig]
    void RSSetState(ID3D11RasterizerState? pRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetviewports
    [PreserveSig]
    void RSSetViewports(uint NumViewports, nint /* optional D3D11_VIEWPORT* */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rssetscissorrects
    [PreserveSig]
    void RSSetScissorRects(uint NumRects, nint /* optional RECT* */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copysubresourceregion
    [PreserveSig]
    void CopySubresourceRegion(ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource pSrcResource, uint SrcSubresource, nint /* optional D3D11_BOX* */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copyresource
    [PreserveSig]
    void CopyResource(ID3D11Resource pDstResource, ID3D11Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-updatesubresource
    [PreserveSig]
    void UpdateSubresource(ID3D11Resource pDstResource, uint DstSubresource, nint /* optional D3D11_BOX* */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-copystructurecount
    [PreserveSig]
    void CopyStructureCount(ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView pSrcView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearrendertargetview
    [PreserveSig]
    void ClearRenderTargetView(ID3D11RenderTargetView pRenderTargetView, [In][MarshalUsing(ConstantElementCount = 4)] float[] ColorRGBA);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearunorderedaccessviewuint
    [PreserveSig]
    void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView pUnorderedAccessView, [In][MarshalUsing(ConstantElementCount = 4)] uint[] Values);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearunorderedaccessviewfloat
    [PreserveSig]
    void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView pUnorderedAccessView, [In][MarshalUsing(ConstantElementCount = 4)] float[] Values);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cleardepthstencilview
    [PreserveSig]
    void ClearDepthStencilView(ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-generatemips
    [PreserveSig]
    void GenerateMips(ID3D11ShaderResourceView pShaderResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-setresourceminlod
    [PreserveSig]
    void SetResourceMinLOD(ID3D11Resource pResource, float MinLOD);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getresourceminlod
    [PreserveSig]
    float GetResourceMinLOD(ID3D11Resource pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-resolvesubresource
    [PreserveSig]
    void ResolveSubresource(ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-executecommandlist
    [PreserveSig]
    void ExecuteCommandList(ID3D11CommandList pCommandList, BOOL RestoreContextState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetshaderresources
    [PreserveSig]
    void HSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetshader
    [PreserveSig]
    void HSSetShader(ID3D11HullShader? pHullShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetsamplers
    [PreserveSig]
    void HSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hssetconstantbuffers
    [PreserveSig]
    void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetshaderresources
    [PreserveSig]
    void DSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetshader
    [PreserveSig]
    void DSSetShader(ID3D11DomainShader? pDomainShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetsamplers
    [PreserveSig]
    void DSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dssetconstantbuffers
    [PreserveSig]
    void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetshaderresources
    [PreserveSig]
    void CSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetunorderedaccessviews
    [PreserveSig]
    void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, nint /* optional ID3D11UnorderedAccessView* */ ppUnorderedAccessViews, nint /* optional uint* */ pUAVInitialCounts);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetshader
    [PreserveSig]
    void CSSetShader(ID3D11ComputeShader? pComputeShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, uint NumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetsamplers
    [PreserveSig]
    void CSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-cssetconstantbuffers
    [PreserveSig]
    void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetconstantbuffers
    [PreserveSig]
    void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetshaderresources
    [PreserveSig]
    void PSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetshader
    [PreserveSig]
    void PSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11PixelShader>))] out ID3D11PixelShader ppPixelShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetsamplers
    [PreserveSig]
    void PSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetshader
    [PreserveSig]
    void VSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VertexShader>))] out ID3D11VertexShader ppVertexShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-psgetconstantbuffers
    [PreserveSig]
    void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetinputlayout
    [PreserveSig]
    void IAGetInputLayout([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11InputLayout>))] out ID3D11InputLayout ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetvertexbuffers
    [PreserveSig]
    void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppVertexBuffers, nint /* optional uint* */ pStrides, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetindexbuffer
    [PreserveSig]
    void IAGetIndexBuffer(nint /* optional ID3D11Buffer* */ pIndexBuffer, nint /* optional DXGI_FORMAT* */ Format, nint /* optional uint* */ Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetconstantbuffers
    [PreserveSig]
    void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetshader
    [PreserveSig]
    void GSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11GeometryShader>))] out ID3D11GeometryShader ppGeometryShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-iagetprimitivetopology
    [PreserveSig]
    void IAGetPrimitiveTopology(out D3D_PRIMITIVE_TOPOLOGY pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetshaderresources
    [PreserveSig]
    void VSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-vsgetsamplers
    [PreserveSig]
    void VSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getpredication
    [PreserveSig]
    void GetPredication(nint /* optional ID3D11Predicate* */ ppPredicate, nint /* optional BOOL* */ pPredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetshaderresources
    [PreserveSig]
    void GSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gsgetsamplers
    [PreserveSig]
    void GSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetrendertargets
    [PreserveSig]
    void OMGetRenderTargets(uint NumViews, nint /* optional ID3D11RenderTargetView* */ ppRenderTargetViews, nint /* optional ID3D11DepthStencilView* */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetrendertargetsandunorderedaccessviews
    [PreserveSig]
    void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, nint /* optional ID3D11RenderTargetView* */ ppRenderTargetViews, nint /* optional ID3D11DepthStencilView* */ ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, nint /* optional ID3D11UnorderedAccessView* */ ppUnorderedAccessViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetblendstate
    [PreserveSig]
    void OMGetBlendState(nint /* optional ID3D11BlendState* */ ppBlendState, nint /* optional float* */ BlendFactor, nint /* optional uint* */ pSampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-omgetdepthstencilstate
    [PreserveSig]
    void OMGetDepthStencilState(nint /* optional ID3D11DepthStencilState* */ ppDepthStencilState, nint /* optional uint* */ pStencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-sogettargets
    [PreserveSig]
    void SOGetTargets(uint NumBuffers, nint /* optional ID3D11Buffer* */ ppSOTargets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetstate
    [PreserveSig]
    void RSGetState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11RasterizerState>))] out ID3D11RasterizerState ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetviewports
    [PreserveSig]
    void RSGetViewports(ref uint pNumViewports, nint /* optional D3D11_VIEWPORT* */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-rsgetscissorrects
    [PreserveSig]
    void RSGetScissorRects(ref uint pNumRects, nint /* optional RECT* */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetshaderresources
    [PreserveSig]
    void HSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetshader
    [PreserveSig]
    void HSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11HullShader>))] out ID3D11HullShader ppHullShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetsamplers
    [PreserveSig]
    void HSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-hsgetconstantbuffers
    [PreserveSig]
    void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetshaderresources
    [PreserveSig]
    void DSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetshader
    [PreserveSig]
    void DSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DomainShader>))] out ID3D11DomainShader ppDomainShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetsamplers
    [PreserveSig]
    void DSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-dsgetconstantbuffers
    [PreserveSig]
    void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetshaderresources
    [PreserveSig]
    void CSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D11ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetunorderedaccessviews
    [PreserveSig]
    void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, nint /* optional ID3D11UnorderedAccessView* */ ppUnorderedAccessViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetshader
    [PreserveSig]
    void CSGetShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11ComputeShader>))] out ID3D11ComputeShader ppComputeShader, nint /* optional ID3D11ClassInstance* */ ppClassInstances, nint /* optional uint* */ pNumClassInstances);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetsamplers
    [PreserveSig]
    void CSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D11SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-csgetconstantbuffers
    [PreserveSig]
    void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-clearstate
    [PreserveSig]
    void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-flush
    [PreserveSig]
    void Flush();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-gettype
    [PreserveSig]
    D3D11_DEVICE_CONTEXT_TYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-getcontextflags
    [PreserveSig]
    uint GetContextFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicecontext-finishcommandlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinishCommandList(BOOL RestoreDeferredContextState, nint /* optional ID3D11CommandList* */ ppCommandList);
}
