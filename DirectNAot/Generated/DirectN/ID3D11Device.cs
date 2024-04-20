namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11device
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
public partial interface ID3D11Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBuffer(in D3D11_BUFFER_DESC pDesc, nint/* nint */ pInitialData, nint/* nint */ ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createtexture1d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture1D(in D3D11_TEXTURE1D_DESC pDesc, nint/* nint */ pInitialData, nint/* nint */ ppTexture1D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createtexture2d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture2D(in D3D11_TEXTURE2D_DESC pDesc, nint/* nint */ pInitialData, nint/* nint */ ppTexture2D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createtexture3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture3D(in D3D11_TEXTURE3D_DESC pDesc, nint/* nint */ pInitialData, nint/* nint */ ppTexture3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createshaderresourceview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderResourceView(ID3D11Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppSRView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createunorderedaccessview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateUnorderedAccessView(ID3D11Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppUAView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createrendertargetview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderTargetView(ID3D11Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppRTView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createdepthstencilview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilView(ID3D11Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppDepthStencilView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createinputlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInputLayout(in D3D11_INPUT_ELEMENT_DESC pInputElementDescs, uint NumElements, nint pShaderBytecodeWithInputSignature, nuint BytecodeLength, nint/* nint */ ppInputLayout);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppVertexShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-creategeometryshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-creategeometryshaderwithstreamoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryShaderWithStreamOutput(nint pShaderBytecode, nuint BytecodeLength, nint/* nint */ pSODeclaration, uint NumEntries, nint/* nint */ pBufferStrides, uint NumStrides, uint RasterizedStream, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppGeometryShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePixelShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppPixelShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createhullshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHullShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppHullShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createdomainshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDomainShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppDomainShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createcomputeshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComputeShader(nint pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage pClassLinkage, nint/* nint */ ppComputeShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createclasslinkage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateClassLinkage(out ID3D11ClassLinkage ppLinkage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createblendstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlendState(in D3D11_BLEND_DESC pBlendStateDesc, nint/* nint */ ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createdepthstencilstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilState(in D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, nint/* nint */ ppDepthStencilState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createrasterizerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizerState(in D3D11_RASTERIZER_DESC pRasterizerDesc, nint/* nint */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createsamplerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSamplerState(in D3D11_SAMPLER_DESC pSamplerDesc, nint/* nint */ ppSamplerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQuery(in D3D11_QUERY_DESC pQueryDesc, nint/* nint */ ppQuery);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createpredicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePredicate(in D3D11_QUERY_DESC pPredicateDesc, nint/* nint */ ppPredicate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCounter(in D3D11_COUNTER_DESC pCounterDesc, nint/* nint */ ppCounter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-createdeferredcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeferredContext(uint ContextFlags, nint/* nint */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-opensharedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedResource(HANDLE hResource, in Guid ReturnedInterface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-checkformatsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFormatSupport(DXGI_FORMAT Format, out uint pFormatSupport);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-checkmultisamplequalitylevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, out uint pNumQualityLevels);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-checkcounterinfo
    [PreserveSig]
    void CheckCounterInfo(out D3D11_COUNTER_INFO pCounterInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-checkcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCounter(in D3D11_COUNTER_DESC pDesc, out D3D11_COUNTER_TYPE pType, out uint pActiveCounters, out PSTR szName, nint/* nint */ pNameLength, out PSTR szUnits, nint/* nint */ pUnitsLength, out PSTR szDescription, nint/* nint */ pDescriptionLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport(D3D11_FEATURE Feature, nint pFeatureSupportData, uint FeatureSupportDataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid guid, ref uint pDataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid guid, uint DataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getfeaturelevel
    [PreserveSig]
    D3D_FEATURE_LEVEL GetFeatureLevel();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getcreationflags
    [PreserveSig]
    uint GetCreationFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getdeviceremovedreason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceRemovedReason();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getimmediatecontext
    [PreserveSig]
    void GetImmediateContext(out ID3D11DeviceContext ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-setexceptionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExceptionMode(uint RaiseFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11device-getexceptionmode
    [PreserveSig]
    uint GetExceptionMode();
}
