namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10device
[GeneratedComInterface, Guid("9b7e4c0f-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetconstantbuffers
    [PreserveSig]
    public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetshaderresources
    [PreserveSig]
    public void PSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetshader
    [PreserveSig]
    public void PSSetShader(ID3D10PixelShader pPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetsamplers
    [PreserveSig]
    public void PSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetshader
    [PreserveSig]
    public void VSSetShader(ID3D10VertexShader pVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawindexed
    [PreserveSig]
    public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-draw
    [PreserveSig]
    public void Draw(uint VertexCount, uint StartVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetconstantbuffers
    [PreserveSig]
    public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetinputlayout
    [PreserveSig]
    public void IASetInputLayout(ID3D10InputLayout pInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetvertexbuffers
    [PreserveSig]
    public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppVertexBuffers, nint/* nint */ pStrides, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetindexbuffer
    [PreserveSig]
    public void IASetIndexBuffer(ID3D10Buffer pIndexBuffer, DXGI_FORMAT Format, uint Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawindexedinstanced
    [PreserveSig]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawinstanced
    [PreserveSig]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetconstantbuffers
    [PreserveSig]
    public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetshader
    [PreserveSig]
    public void GSSetShader(ID3D10GeometryShader pShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetprimitivetopology
    [PreserveSig]
    public void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY Topology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetshaderresources
    [PreserveSig]
    public void VSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetsamplers
    [PreserveSig]
    public void VSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setpredication
    [PreserveSig]
    public void SetPredication(ID3D10Predicate pPredicate, [MarshalAs(UnmanagedType.U4)] bool PredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetshaderresources
    [PreserveSig]
    public void GSSetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetsamplers
    [PreserveSig]
    public void GSSetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetrendertargets
    [PreserveSig]
    public void OMSetRenderTargets(uint NumViews, nint/* nint */ ppRenderTargetViews, ID3D10DepthStencilView pDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetblendstate
    [PreserveSig]
    public void OMSetBlendState(ID3D10BlendState pBlendState, in float BlendFactor, uint SampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetdepthstencilstate
    [PreserveSig]
    public void OMSetDepthStencilState(ID3D10DepthStencilState pDepthStencilState, uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-sosettargets
    [PreserveSig]
    public void SOSetTargets(uint NumBuffers, nint/* nint */ ppSOTargets, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawauto
    [PreserveSig]
    public void DrawAuto();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetstate
    [PreserveSig]
    public void RSSetState(ID3D10RasterizerState pRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetviewports
    [PreserveSig]
    public void RSSetViewports(uint NumViewports, nint/* nint */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetscissorrects
    [PreserveSig]
    public void RSSetScissorRects(uint NumRects, nint/* nint */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-copysubresourceregion
    [PreserveSig]
    public void CopySubresourceRegion(ID3D10Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D10Resource pSrcResource, uint SrcSubresource, nint/* nint */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-copyresource
    [PreserveSig]
    public void CopyResource(ID3D10Resource pDstResource, ID3D10Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-updatesubresource
    [PreserveSig]
    public void UpdateSubresource(ID3D10Resource pDstResource, uint DstSubresource, nint/* nint */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-clearrendertargetview
    [PreserveSig]
    public void ClearRenderTargetView(ID3D10RenderTargetView pRenderTargetView, in float ColorRGBA);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-cleardepthstencilview
    [PreserveSig]
    public void ClearDepthStencilView(ID3D10DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-generatemips
    [PreserveSig]
    public void GenerateMips(ID3D10ShaderResourceView pShaderResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-resolvesubresource
    [PreserveSig]
    public void ResolveSubresource(ID3D10Resource pDstResource, uint DstSubresource, ID3D10Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetconstantbuffers
    [PreserveSig]
    public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetshaderresources
    [PreserveSig]
    public void PSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetshader
    [PreserveSig]
    public void PSGetShader(out ID3D10PixelShader ppPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetsamplers
    [PreserveSig]
    public void PSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetshader
    [PreserveSig]
    public void VSGetShader(out ID3D10VertexShader ppVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetconstantbuffers
    [PreserveSig]
    public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetinputlayout
    [PreserveSig]
    public void IAGetInputLayout(out ID3D10InputLayout ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetvertexbuffers
    [PreserveSig]
    public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppVertexBuffers, nint/* nint */ pStrides, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetindexbuffer
    [PreserveSig]
    public void IAGetIndexBuffer(nint/* nint */ pIndexBuffer, nint/* nint */ Format, nint/* nint */ Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetconstantbuffers
    [PreserveSig]
    public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetshader
    [PreserveSig]
    public void GSGetShader(out ID3D10GeometryShader ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetprimitivetopology
    [PreserveSig]
    public void IAGetPrimitiveTopology(out D3D_PRIMITIVE_TOPOLOGY pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetshaderresources
    [PreserveSig]
    public void VSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetsamplers
    [PreserveSig]
    public void VSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getpredication
    [PreserveSig]
    public void GetPredication(nint/* nint */ ppPredicate, nint/* nint */ pPredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetshaderresources
    [PreserveSig]
    public void GSGetShaderResources(uint StartSlot, uint NumViews, nint/* nint */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetsamplers
    [PreserveSig]
    public void GSGetSamplers(uint StartSlot, uint NumSamplers, nint/* nint */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetrendertargets
    [PreserveSig]
    public void OMGetRenderTargets(uint NumViews, nint/* nint */ ppRenderTargetViews, nint/* nint */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetblendstate
    [PreserveSig]
    public void OMGetBlendState(nint/* nint */ ppBlendState, nint/* nint */ BlendFactor, nint/* nint */ pSampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetdepthstencilstate
    [PreserveSig]
    public void OMGetDepthStencilState(nint/* nint */ ppDepthStencilState, nint/* nint */ pStencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-sogettargets
    [PreserveSig]
    public void SOGetTargets(uint NumBuffers, nint/* nint */ ppSOTargets, nint/* nint */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetstate
    [PreserveSig]
    public void RSGetState(out ID3D10RasterizerState ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetviewports
    [PreserveSig]
    public void RSGetViewports(ref uint NumViewports, nint/* nint */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetscissorrects
    [PreserveSig]
    public void RSGetScissorRects(ref uint NumRects, nint/* nint */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getdeviceremovedreason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDeviceRemovedReason();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setexceptionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetExceptionMode(uint RaiseFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getexceptionmode
    [PreserveSig]
    public uint GetExceptionMode();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrivateData(in Guid guid, ref uint pDataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateData(in Guid guid, uint DataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-clearstate
    [PreserveSig]
    public void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-flush
    [PreserveSig]
    public void Flush();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBuffer(in D3D10_BUFFER_DESC pDesc, nint/* nint */ pInitialData, nint/* nint */ ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture1d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTexture1D(in D3D10_TEXTURE1D_DESC pDesc, nint/* nint */ pInitialData, out ID3D10Texture1D ppTexture1D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture2d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTexture2D(in D3D10_TEXTURE2D_DESC pDesc, nint/* nint */ pInitialData, out ID3D10Texture2D ppTexture2D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTexture3D(in D3D10_TEXTURE3D_DESC pDesc, nint/* nint */ pInitialData, out ID3D10Texture3D ppTexture3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createshaderresourceview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateShaderResourceView(ID3D10Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppSRView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createrendertargetview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRenderTargetView(ID3D10Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppRTView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createdepthstencilview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDepthStencilView(ID3D10Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createinputlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInputLayout(in D3D10_INPUT_ELEMENT_DESC pInputElementDescs, uint NumElements, nint pShaderBytecodeWithInputSignature, nuint BytecodeLength, nint/* nint */ ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVertexShader(nint pShaderBytecode, nuint BytecodeLength, nint/* nint */ ppVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-creategeometryshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGeometryShader(nint pShaderBytecode, nuint BytecodeLength, nint/* nint */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-creategeometryshaderwithstreamoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGeometryShaderWithStreamOutput(nint pShaderBytecode, nuint BytecodeLength, nint/* nint */ pSODeclaration, uint NumEntries, uint OutputStreamStride, nint/* nint */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePixelShader(nint pShaderBytecode, nuint BytecodeLength, nint/* nint */ ppPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createblendstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlendState(in D3D10_BLEND_DESC pBlendStateDesc, nint/* nint */ ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createdepthstencilstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDepthStencilState(in D3D10_DEPTH_STENCIL_DESC pDepthStencilDesc, nint/* nint */ ppDepthStencilState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createrasterizerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRasterizerState(in D3D10_RASTERIZER_DESC pRasterizerDesc, nint/* nint */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createsamplerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSamplerState(in D3D10_SAMPLER_DESC pSamplerDesc, nint/* nint */ ppSamplerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateQuery(in D3D10_QUERY_DESC pQueryDesc, nint/* nint */ ppQuery);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createpredicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePredicate(in D3D10_QUERY_DESC pPredicateDesc, nint/* nint */ ppPredicate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCounter(in D3D10_COUNTER_DESC pCounterDesc, nint/* nint */ ppCounter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkformatsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckFormatSupport(DXGI_FORMAT Format, out uint pFormatSupport);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkmultisamplequalitylevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, out uint pNumQualityLevels);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkcounterinfo
    [PreserveSig]
    public void CheckCounterInfo(out D3D10_COUNTER_INFO pCounterInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckCounter(in D3D10_COUNTER_DESC pDesc, out D3D10_COUNTER_TYPE pType, out uint pActiveCounters, out PSTR szName, nint/* nint */ pNameLength, out PSTR szUnits, nint/* nint */ pUnitsLength, out PSTR szDescription, nint/* nint */ pDescriptionLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getcreationflags
    [PreserveSig]
    public uint GetCreationFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-opensharedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OpenSharedResource(HANDLE hResource, in Guid ReturnedInterface, nint/* nint */ ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-settextfiltersize
    [PreserveSig]
    public void SetTextFilterSize(uint Width, uint Height);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gettextfiltersize
    [PreserveSig]
    public void GetTextFilterSize(nint/* nint */ pWidth, nint/* nint */ pHeight);
}
