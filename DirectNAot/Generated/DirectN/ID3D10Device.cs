namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10device
[GeneratedComInterface, Guid("9b7e4c0f-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetconstantbuffers
    [PreserveSig]
    void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetshaderresources
    [PreserveSig]
    void PSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetshader
    [PreserveSig]
    void PSSetShader(ID3D10PixelShader? pPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetsamplers
    [PreserveSig]
    void PSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetshader
    [PreserveSig]
    void VSSetShader(ID3D10VertexShader? pVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawindexed
    [PreserveSig]
    void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-draw
    [PreserveSig]
    void Draw(uint VertexCount, uint StartVertexLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-pssetconstantbuffers
    [PreserveSig]
    void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetinputlayout
    [PreserveSig]
    void IASetInputLayout(ID3D10InputLayout? pInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetvertexbuffers
    [PreserveSig]
    void IASetVertexBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppVertexBuffers, nint /* optional uint* */ pStrides, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetindexbuffer
    [PreserveSig]
    void IASetIndexBuffer(ID3D10Buffer? pIndexBuffer, DXGI_FORMAT Format, uint Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawindexedinstanced
    [PreserveSig]
    void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawinstanced
    [PreserveSig]
    void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetconstantbuffers
    [PreserveSig]
    void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetshader
    [PreserveSig]
    void GSSetShader(ID3D10GeometryShader? pShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iasetprimitivetopology
    [PreserveSig]
    void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY Topology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetshaderresources
    [PreserveSig]
    void VSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vssetsamplers
    [PreserveSig]
    void VSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setpredication
    [PreserveSig]
    void SetPredication(ID3D10Predicate? pPredicate, [MarshalAs(UnmanagedType.U4)] bool PredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetshaderresources
    [PreserveSig]
    void GSSetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gssetsamplers
    [PreserveSig]
    void GSSetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetrendertargets
    [PreserveSig]
    void OMSetRenderTargets(uint NumViews, nint /* optional ID3D10RenderTargetView* */ ppRenderTargetViews, ID3D10DepthStencilView? pDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetblendstate
    [PreserveSig]
    void OMSetBlendState(ID3D10BlendState? pBlendState, [MarshalUsing(ConstantElementCount = 4)] in float[] BlendFactor, uint SampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omsetdepthstencilstate
    [PreserveSig]
    void OMSetDepthStencilState(ID3D10DepthStencilState? pDepthStencilState, uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-sosettargets
    [PreserveSig]
    void SOSetTargets(uint NumBuffers, nint /* optional ID3D10Buffer* */ ppSOTargets, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-drawauto
    [PreserveSig]
    void DrawAuto();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetstate
    [PreserveSig]
    void RSSetState(ID3D10RasterizerState? pRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetviewports
    [PreserveSig]
    void RSSetViewports(uint NumViewports, nint /* optional D3D10_VIEWPORT* */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rssetscissorrects
    [PreserveSig]
    void RSSetScissorRects(uint NumRects, nint /* optional FoundationRECT* */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-copysubresourceregion
    [PreserveSig]
    void CopySubresourceRegion(ID3D10Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D10Resource pSrcResource, uint SrcSubresource, nint /* optional D3D10_BOX* */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-copyresource
    [PreserveSig]
    void CopyResource(ID3D10Resource pDstResource, ID3D10Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-updatesubresource
    [PreserveSig]
    void UpdateSubresource(ID3D10Resource pDstResource, uint DstSubresource, nint /* optional D3D10_BOX* */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-clearrendertargetview
    [PreserveSig]
    void ClearRenderTargetView(ID3D10RenderTargetView pRenderTargetView, [MarshalUsing(ConstantElementCount = 4)] in float[] ColorRGBA);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-cleardepthstencilview
    [PreserveSig]
    void ClearDepthStencilView(ID3D10DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-generatemips
    [PreserveSig]
    void GenerateMips(ID3D10ShaderResourceView pShaderResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-resolvesubresource
    [PreserveSig]
    void ResolveSubresource(ID3D10Resource pDstResource, uint DstSubresource, ID3D10Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetconstantbuffers
    [PreserveSig]
    void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetshaderresources
    [PreserveSig]
    void PSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetshader
    [PreserveSig]
    void PSGetShader(out ID3D10PixelShader ppPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetsamplers
    [PreserveSig]
    void PSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetshader
    [PreserveSig]
    void VSGetShader(out ID3D10VertexShader ppVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-psgetconstantbuffers
    [PreserveSig]
    void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetinputlayout
    [PreserveSig]
    void IAGetInputLayout(out ID3D10InputLayout ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetvertexbuffers
    [PreserveSig]
    void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppVertexBuffers, nint /* optional uint* */ pStrides, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetindexbuffer
    [PreserveSig]
    void IAGetIndexBuffer(nint /* optional ID3D10Buffer* */ pIndexBuffer, nint /* optional DXGI_FORMAT* */ Format, nint /* optional uint* */ Offset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetconstantbuffers
    [PreserveSig]
    void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, nint /* optional ID3D10Buffer* */ ppConstantBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetshader
    [PreserveSig]
    void GSGetShader(out ID3D10GeometryShader ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-iagetprimitivetopology
    [PreserveSig]
    void IAGetPrimitiveTopology(out D3D_PRIMITIVE_TOPOLOGY pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetshaderresources
    [PreserveSig]
    void VSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-vsgetsamplers
    [PreserveSig]
    void VSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getpredication
    [PreserveSig]
    void GetPredication(nint /* optional ID3D10Predicate* */ ppPredicate, nint /* optional bool* */ pPredicateValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetshaderresources
    [PreserveSig]
    void GSGetShaderResources(uint StartSlot, uint NumViews, nint /* optional ID3D10ShaderResourceView* */ ppShaderResourceViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gsgetsamplers
    [PreserveSig]
    void GSGetSamplers(uint StartSlot, uint NumSamplers, nint /* optional ID3D10SamplerState* */ ppSamplers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetrendertargets
    [PreserveSig]
    void OMGetRenderTargets(uint NumViews, nint /* optional ID3D10RenderTargetView* */ ppRenderTargetViews, nint /* optional ID3D10DepthStencilView* */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetblendstate
    [PreserveSig]
    void OMGetBlendState(nint /* optional ID3D10BlendState* */ ppBlendState, nint /* optional float* */ BlendFactor, nint /* optional uint* */ pSampleMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-omgetdepthstencilstate
    [PreserveSig]
    void OMGetDepthStencilState(nint /* optional ID3D10DepthStencilState* */ ppDepthStencilState, nint /* optional uint* */ pStencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-sogettargets
    [PreserveSig]
    void SOGetTargets(uint NumBuffers, nint /* optional ID3D10Buffer* */ ppSOTargets, nint /* optional uint* */ pOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetstate
    [PreserveSig]
    void RSGetState(out ID3D10RasterizerState ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetviewports
    [PreserveSig]
    void RSGetViewports(ref uint NumViewports, nint /* optional D3D10_VIEWPORT* */ pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-rsgetscissorrects
    [PreserveSig]
    void RSGetScissorRects(ref uint NumRects, nint /* optional FoundationRECT* */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getdeviceremovedreason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceRemovedReason();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setexceptionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExceptionMode(uint RaiseFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getexceptionmode
    [PreserveSig]
    uint GetExceptionMode();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid guid, ref uint pDataSize, nint /* optional void* */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid guid, uint DataSize, nint /* optional void* */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-clearstate
    [PreserveSig]
    void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-flush
    [PreserveSig]
    void Flush();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBuffer(in D3D10_BUFFER_DESC pDesc, nint /* optional D3D10_SUBRESOURCE_DATA* */ pInitialData, nint /* optional ID3D10Buffer* */ ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture1d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture1D(in D3D10_TEXTURE1D_DESC pDesc, nint /* optional D3D10_SUBRESOURCE_DATA* */ pInitialData, out ID3D10Texture1D ppTexture1D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture2d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture2D(in D3D10_TEXTURE2D_DESC pDesc, nint /* optional D3D10_SUBRESOURCE_DATA* */ pInitialData, out ID3D10Texture2D ppTexture2D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createtexture3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture3D(in D3D10_TEXTURE3D_DESC pDesc, nint /* optional D3D10_SUBRESOURCE_DATA* */ pInitialData, out ID3D10Texture3D ppTexture3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createshaderresourceview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderResourceView(ID3D10Resource pResource, nint /* optional D3D10_SHADER_RESOURCE_VIEW_DESC* */ pDesc, nint /* optional ID3D10ShaderResourceView* */ ppSRView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createrendertargetview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderTargetView(ID3D10Resource pResource, nint /* optional D3D10_RENDER_TARGET_VIEW_DESC* */ pDesc, nint /* optional ID3D10RenderTargetView* */ ppRTView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createdepthstencilview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilView(ID3D10Resource pResource, nint /* optional D3D10_DEPTH_STENCIL_VIEW_DESC* */ pDesc, nint /* optional ID3D10DepthStencilView* */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createinputlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInputLayout([MarshalUsing(CountElementName = nameof(NumElements))] in D3D10_INPUT_ELEMENT_DESC[] pInputElementDescs, uint NumElements, nint pShaderBytecodeWithInputSignature, nuint BytecodeLength, nint /* optional ID3D10InputLayout* */ ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexShader(nint pShaderBytecode, nuint BytecodeLength, nint /* optional ID3D10VertexShader* */ ppVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-creategeometryshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryShader(nint pShaderBytecode, nuint BytecodeLength, nint /* optional ID3D10GeometryShader* */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-creategeometryshaderwithstreamoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryShaderWithStreamOutput(nint pShaderBytecode, nuint BytecodeLength, nint /* optional D3D10_SO_DECLARATION_ENTRY* */ pSODeclaration, uint NumEntries, uint OutputStreamStride, nint /* optional ID3D10GeometryShader* */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePixelShader(nint pShaderBytecode, nuint BytecodeLength, nint /* optional ID3D10PixelShader* */ ppPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createblendstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlendState(in D3D10_BLEND_DESC pBlendStateDesc, nint /* optional ID3D10BlendState* */ ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createdepthstencilstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilState(in D3D10_DEPTH_STENCIL_DESC pDepthStencilDesc, nint /* optional ID3D10DepthStencilState* */ ppDepthStencilState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createrasterizerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizerState(in D3D10_RASTERIZER_DESC pRasterizerDesc, nint /* optional ID3D10RasterizerState* */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createsamplerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSamplerState(in D3D10_SAMPLER_DESC pSamplerDesc, nint /* optional ID3D10SamplerState* */ ppSamplerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQuery(in D3D10_QUERY_DESC pQueryDesc, nint /* optional ID3D10Query* */ ppQuery);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createpredicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePredicate(in D3D10_QUERY_DESC pPredicateDesc, nint /* optional ID3D10Predicate* */ ppPredicate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-createcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCounter(in D3D10_COUNTER_DESC pCounterDesc, nint /* optional ID3D10Counter* */ ppCounter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkformatsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFormatSupport(DXGI_FORMAT Format, out uint pFormatSupport);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkmultisamplequalitylevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, out uint pNumQualityLevels);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkcounterinfo
    [PreserveSig]
    void CheckCounterInfo(out D3D10_COUNTER_INFO pCounterInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-checkcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCounter(in D3D10_COUNTER_DESC pDesc, out D3D10_COUNTER_TYPE pType, out uint pActiveCounters, [MarshalUsing(CountElementName = nameof(pNameLength))] out PSTR[] szName, nint /* optional uint* */ pNameLength, [MarshalUsing(CountElementName = nameof(pUnitsLength))] out PSTR[] szUnits, nint /* optional uint* */ pUnitsLength, [MarshalUsing(CountElementName = nameof(pDescriptionLength))] out PSTR[] szDescription, nint /* optional uint* */ pDescriptionLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-getcreationflags
    [PreserveSig]
    uint GetCreationFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-opensharedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedResource(HANDLE hResource, in Guid ReturnedInterface, nint /* optional void** */ ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-settextfiltersize
    [PreserveSig]
    void SetTextFilterSize(uint Width, uint Height);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10device-gettextfiltersize
    [PreserveSig]
    void GetTextFilterSize(nint /* optional uint* */ pWidth, nint /* optional uint* */ pHeight);
}
