namespace DirectN;

public static partial class Functions
{
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-choosepixelformat
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ChoosePixelFormat(HDC hdc, in PIXELFORMATDESCRIPTOR ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory(in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory1(in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-createdxgifactory2
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory2(uint Flags, in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-createpresentationfactory
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT CreatePresentationFactory(nint d3dDevice, in Guid riid, out nint presentationFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-d2d1computemaximumscalefactor
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial float D2D1ComputeMaximumScaleFactor(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1convertcolorspace
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial D2D1_COLOR_F D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, in D2D1_COLOR_F color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevice
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDevice(IDXGIDevice dxgiDevice, nint/* nint */ creationProperties, out ID2D1Device d2dDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevicecontext
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDeviceContext(IDXGISurface dxgiSurface, nint/* nint */ creationProperties, out ID2D1DeviceContext d2dDeviceContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1createfactory
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, in Guid riid, nint/* nint */ pFactoryOptions, out nint ppIFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-d2d1getgradientmeshinteriorpointsfromcoonspatch
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(in D2D_POINT_2F pPoint0, in D2D_POINT_2F pPoint1, in D2D_POINT_2F pPoint2, in D2D_POINT_2F pPoint3, in D2D_POINT_2F pPoint4, in D2D_POINT_2F pPoint5, in D2D_POINT_2F pPoint6, in D2D_POINT_2F pPoint7, in D2D_POINT_2F pPoint8, in D2D_POINT_2F pPoint9, in D2D_POINT_2F pPoint10, in D2D_POINT_2F pPoint11, out D2D_POINT_2F pTensorPoint11, out D2D_POINT_2F pTensorPoint12, out D2D_POINT_2F pTensorPoint21, out D2D_POINT_2F pTensorPoint22);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1invertmatrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D2D1InvertMatrix(ref D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1ismatrixinvertible
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D2D1IsMatrixInvertible(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makerotatematrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeRotateMatrix(float angle, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makeskewmatrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeSkewMatrix(float angleX, float angleY, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1sincos
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial void D2D1SinCos(float angle, out float s, out float c);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1tan
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Tan(float angle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1vec3length
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Vec3Length(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10compileeffectfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CompileEffectFromMemory(nint pData, nuint DataLength, PSTR pSrcFileName, nint/* nint */ pDefines, ID3DInclude pInclude, uint HLSLFlags, uint FXFlags, out ID3DBlob ppCompiledEffect, nint/* nint */ ppErrors);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10compileshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CompileShader(PSTR pSrcData, nuint SrcDataSize, PSTR pFileName, nint/* nint */ pDefines, ID3DInclude pInclude, PSTR pFunctionName, PSTR pProfile, uint Flags, out ID3DBlob ppShader, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateBlob(nuint NumBytes, out ID3DBlob ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createdevice
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDevice(IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, nint/* nint */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-d3d10createdevice1
    [LibraryImport("d3d10_1")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDevice1(IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, nint/* nint */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createdeviceandswapchain
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDeviceAndSwapChain(IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, nint/* nint */ pSwapChainDesc, nint/* nint */ ppSwapChain, nint/* nint */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-d3d10createdeviceandswapchain1
    [LibraryImport("d3d10_1")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDeviceAndSwapChain1(IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, nint/* nint */ pSwapChainDesc, nint/* nint */ ppSwapChain, nint/* nint */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createeffectfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateEffectFromMemory(nint pData, nuint DataLength, uint FXFlags, ID3D10Device pDevice, ID3D10EffectPool pEffectPool, out ID3D10Effect ppEffect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createeffectpoolfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateEffectPoolFromMemory(nint pData, nuint DataLength, uint FXFlags, ID3D10Device pDevice, out ID3D10EffectPool ppEffectPool);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createstateblock
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateStateBlock(ID3D10Device pDevice, in D3D10_STATE_BLOCK_MASK pStateBlockMask, out ID3D10StateBlock ppStateBlock);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10disassembleeffect
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10DisassembleEffect(ID3D10Effect pEffect, [MarshalAs(UnmanagedType.U4)] bool EnableColorCode, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10disassembleshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10DisassembleShader(nint pShader, nuint BytecodeLength, [MarshalAs(UnmanagedType.U4)] bool EnableColorCode, PSTR pComments, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getgeometryshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial PSTR D3D10GetGeometryShaderProfile(ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getinputandoutputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetInputAndOutputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getinputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetInputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getoutputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetOutputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getpixelshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial PSTR D3D10GetPixelShaderProfile(ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getshaderdebuginfo
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetShaderDebugInfo(nint pShaderBytecode, nuint BytecodeLength, out ID3DBlob ppDebugInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getvertexshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial PSTR D3D10GetVertexShaderProfile(ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10preprocessshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10PreprocessShader(PSTR pSrcData, nuint SrcDataSize, PSTR pFileName, nint/* nint */ pDefines, ID3DInclude pInclude, out ID3DBlob ppShaderText, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10reflectshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10ReflectShader(nint pShaderBytecode, nuint BytecodeLength, out ID3D10ShaderReflection ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdifference
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDifference(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdisableall
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDisableAll(out D3D10_STATE_BLOCK_MASK pMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdisablecapture
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDisableCapture(ref D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenableall
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskEnableAll(out D3D10_STATE_BLOCK_MASK pMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenablecapture
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskEnableCapture(ref D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskgetsetting
    [LibraryImport("d3d10")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D3D10StateBlockMaskGetSetting(in D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint Entry);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskintersect
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskIntersect(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskunion
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskUnion(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-d3d11createdevice
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11CreateDevice(IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, D3D11_CREATE_DEVICE_FLAG Flags, nint/* nint */ pFeatureLevels, uint FeatureLevels, uint SDKVersion, nint/* nint */ ppDevice, nint/* nint */ pFeatureLevel, nint/* nint */ ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-d3d11createdeviceandswapchain
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11CreateDeviceAndSwapChain(IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, D3D11_CREATE_DEVICE_FLAG Flags, nint/* nint */ pFeatureLevels, uint FeatureLevels, uint SDKVersion, nint/* nint */ pSwapChainDesc, nint/* nint */ ppSwapChain, nint/* nint */ ppDevice, nint/* nint */ pFeatureLevel, nint/* nint */ ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-d3d11on12createdevice
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11On12CreateDevice(nint pDevice, uint Flags, nint/* nint */ pFeatureLevels, uint FeatureLevels, nint/* nint */ ppCommandQueues, uint NumQueues, uint NodeMask, nint/* nint */ ppDevice, nint/* nint */ ppImmediateContext, nint/* nint */ pChosenFeatureLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createdevice
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateDevice(nint pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, in Guid riid, nint/* nint */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createrootsignaturedeserializer
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateRootSignatureDeserializer(nint pSrcData, nuint SrcDataSizeInBytes, in Guid pRootSignatureDeserializerInterface, out nint ppRootSignatureDeserializer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createversionedrootsignaturedeserializer
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateVersionedRootSignatureDeserializer(nint pSrcData, nuint SrcDataSizeInBytes, in Guid pRootSignatureDeserializerInterface, out nint ppRootSignatureDeserializer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12enableexperimentalfeatures
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, in Guid pIIDs, nint/* nint */ pConfigurationStructs, nint/* nint */ pConfigurationStructSizes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12getdebuginterface
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12GetDebugInterface(in Guid riid, nint/* nint */ ppvDebug);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12getinterface
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12GetInterface(in Guid rclsid, in Guid riid, nint/* nint */ ppvDebug);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12serializerootsignature
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12SerializeRootSignature(in D3D12_ROOT_SIGNATURE_DESC pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, out ID3DBlob ppBlob, nint/* nint */ ppErrorBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12serializeversionedrootsignature
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12SerializeVersionedRootSignature(in D3D12_VERSIONED_ROOT_SIGNATURE_DESC pRootSignature, out ID3DBlob ppBlob, nint/* nint */ ppErrorBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompile(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint/* nint */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, out ID3DBlob ppCode, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompile2
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompile2(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint/* nint */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, uint SecondaryDataFlags, nint/* nint */ pSecondaryData, nuint SecondaryDataSize, out ID3DBlob ppCode, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompilefromfile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompileFromFile(PWSTR pFileName, nint/* nint */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, out ID3DBlob ppCode, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompressshaders
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompressShaders(uint uNumShaders, in D3D_SHADER_DATA pShaderData, uint uFlags, out ID3DBlob ppCompressedData);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreateblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateBlob(nuint Size, out ID3DBlob ppBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreatefunctionlinkinggraph
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateFunctionLinkingGraph(uint uFlags, out ID3D11FunctionLinkingGraph ppFunctionLinkingGraph);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreatelinker
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateLinker(out ID3D11Linker ppLinker);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddecompressshaders
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDecompressShaders(nint pSrcData, nuint SrcDataSize, uint uNumShaders, uint uStartIndex, nint/* nint */ pIndices, uint uFlags, out ID3DBlob ppShaders, nint/* nint */ pTotalShaders);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassemble
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble(nint pSrcData, nuint SrcDataSize, uint Flags, PSTR szComments, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassemble10effect
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble10Effect(ID3D10Effect pEffect, uint Flags, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-d3ddisassemble11trace
    [LibraryImport("D3DCOMPILER_47")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble11Trace(nint pSrcData, nuint SrcDataSize, ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassembleregion
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassembleRegion(nint pSrcData, nuint SrcDataSize, uint Flags, PSTR szComments, nuint StartByteOffset, nuint NumInsts, nint/* nint */ pFinishByteOffset, out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetblobpart
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetBlobPart(nint pSrcData, nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, out ID3DBlob ppPart);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetdebuginfo
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetDebugInfo(nint pSrcData, nuint SrcDataSize, out ID3DBlob ppDebugInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetinputandoutputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetInputAndOutputSignatureBlob(nint pSrcData, nuint SrcDataSize, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetinputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetInputSignatureBlob(nint pSrcData, nuint SrcDataSize, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetoutputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetOutputSignatureBlob(nint pSrcData, nuint SrcDataSize, out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgettraceinstructionoffsets
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetTraceInstructionOffsets(nint pSrcData, nuint SrcDataSize, uint Flags, nuint StartInstIndex, nuint NumInsts, nint/* nint */ pOffsets, nint/* nint */ pTotalInsts);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dloadmodule
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DLoadModule(nint pSrcData, nuint cbSrcDataSize, out ID3D11Module ppModule);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_beginevent
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial int D3DPERF_BeginEvent(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_endevent
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial int D3DPERF_EndEvent();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_getstatus
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial uint D3DPERF_GetStatus();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_queryrepeatframe
    [LibraryImport("d3d9")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D3DPERF_QueryRepeatFrame();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setmarker
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetMarker(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setoptions
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetOptions(uint dwOptions);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setregion
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetRegion(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dpreprocess
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DPreprocess(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint/* nint */ pDefines, ID3DInclude pInclude, out ID3DBlob ppCodeText, nint/* nint */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreadfiletoblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReadFileToBlob(PWSTR pFileName, out ID3DBlob ppContents);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreflect
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReflect(nint pSrcData, nuint SrcDataSize, in Guid pInterface, out nint ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreflectlibrary
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReflectLibrary(nint pSrcData, nuint SrcDataSize, in Guid riid, out nint ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dsetblobpart
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DSetBlobPart(nint pSrcData, nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, nint pPart, nuint PartSize, out ID3DBlob ppNewShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dstripshader
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DStripShader(nint pShaderBytecode, nuint BytecodeLength, uint uStripFlags, out ID3DBlob ppStrippedBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dwriteblobtofile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DWriteBlobToFile(ID3DBlob pBlob, PWSTR pFileName, [MarshalAs(UnmanagedType.U4)] bool bOverwrite);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT(ID3D11DeviceContext pDeviceContext, in D3DX11_FFT_DESC pDesc, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft1dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT1DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft1dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT1DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft2dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT2DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft2dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT2DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft3dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT3DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft3dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT3DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createscan
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateScan(ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, uint MaxScanCount, out ID3DX11Scan ppScan);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createsegmentedscan
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateSegmentedScan(ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, out ID3DX11SegmentedScan ppScan);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionattachmousedragtohwnd
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionAttachMouseDragToHwnd(IDCompositionVisual visual, HWND hwnd, [MarshalAs(UnmanagedType.U4)] bool enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionattachmousewheeltohwnd
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionAttachMouseWheelToHwnd(IDCompositionVisual visual, HWND hwnd, [MarshalAs(UnmanagedType.U4)] bool enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionboostcompositorclock
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionBoostCompositorClock([MarshalAs(UnmanagedType.U4)] bool enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice(IDXGIDevice dxgiDevice, in Guid iid, out nint dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice2
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice2(nint renderingDevice, in Guid iid, out nint dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice3
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice3(nint renderingDevice, in Guid iid, out nint dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatesurfacehandle
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateSurfaceHandle(uint desiredAccess, nint/* nint */ securityAttributes, out HANDLE surfaceHandle);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositiongetframeid
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetFrameId(COMPOSITION_FRAME_ID_TYPE frameIdType, out ulong frameId);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositiongetstatistics
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetStatistics(ulong frameId, out COMPOSITION_FRAME_STATS frameStats, uint targetIdCount, nint/* nint */ targetIds, nint/* nint */ actualTargetIdCount);
    
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetTargetStatistics(ulong frameId, in COMPOSITION_TARGET_ID targetId, out COMPOSITION_TARGET_STATS targetStats);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionwaitforcompositorclock
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial uint DCompositionWaitForCompositorClock(uint count, nint/* nint */ handles, uint timeoutInMs);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-describepixelformat
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int DescribePixelFormat(HDC hdc, int iPixelFormat, uint nBytes, nint/* nint */ ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-direct3dcreate9
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial IDirect3D9 Direct3DCreate9(uint SDKVersion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-direct3dcreate9ex
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial HRESULT Direct3DCreate9Ex(uint SDKVersion, out IDirect3D9Ex param1);
    
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial IDirect3D9 Direct3DCreate9On12(uint SDKVersion, ref D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries);
    
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial HRESULT Direct3DCreate9On12Ex(uint SDKVersion, ref D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries, out IDirect3D9Ex ppOutputInterface);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreate
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreate(ref Guid lpGUID, out IDirectDraw lplpDD, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreateclipper
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreateClipper(uint dwFlags, out IDirectDrawClipper lplpDDClipper, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreateex
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreateEx(ref Guid lpGuid, out nint lplpDD, in Guid iid, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumeratea
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateA(LPDDENUMCALLBACKA lpCallback, nint lpContext);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumerateexa
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateExA(LPDDENUMCALLBACKEXA lpCallback, nint lpContext, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumerateexw
    [LibraryImport("DDRAW", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateExW(LPDDENUMCALLBACKEXW lpCallback, nint lpContext, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumeratew
    [LibraryImport("DDRAW", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateW(LPDDENUMCALLBACKW lpCallback, nint lpContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmattachmilcontent
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmAttachMilContent(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmdefwindowproc
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool DwmDefWindowProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam, out LRESULT plResult);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmdetachmilcontent
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmDetachMilContent(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenableblurbehindwindow
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableBlurBehindWindow(HWND hWnd, in DWM_BLURBEHIND pBlurBehind);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenablecomposition
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableComposition(uint uCompositionAction);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenablemmcss
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableMMCSS([MarshalAs(UnmanagedType.U4)] bool fEnableMMCSS);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmextendframeintoclientarea
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmExtendFrameIntoClientArea(HWND hWnd, in MARGINS pMarInset);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmflush
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmFlush();
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetcolorizationcolor
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetColorizationColor(out uint pcrColorization, [MarshalAs(UnmanagedType.U4)] out bool pfOpaqueBlend);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetcompositiontiminginfo
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetCompositionTimingInfo(HWND hwnd, out DWM_TIMING_INFO pTimingInfo);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetgraphicsstreamclient
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetGraphicsStreamClient(uint uIndex, out Guid pClientUuid);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetgraphicsstreamtransformhint
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetGraphicsStreamTransformHint(uint uIndex, out MilMatrix3x2D pTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgettransportattributes
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetTransportAttributes([MarshalAs(UnmanagedType.U4)] out bool pfIsRemoting, [MarshalAs(UnmanagedType.U4)] out bool pfIsConnected, out uint pDwGeneration);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetunmettabrequirements
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT DwmGetUnmetTabRequirements(HWND appWindow, out DWM_TAB_WINDOW_REQUIREMENTS value);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetwindowattribute
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetWindowAttribute(HWND hwnd, uint dwAttribute, nint pvAttribute, uint cbAttribute);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwminvalidateiconicbitmaps
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmInvalidateIconicBitmaps(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmiscompositionenabled
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmIsCompositionEnabled([MarshalAs(UnmanagedType.U4)] out bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmmodifypreviousdxframeduration
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmModifyPreviousDxFrameDuration(HWND hwnd, int cRefreshes, [MarshalAs(UnmanagedType.U4)] bool fRelative);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmquerythumbnailsourcesize
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmQueryThumbnailSourceSize(nint hThumbnail, out FoundationSIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmregisterthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmRegisterThumbnail(HWND hwndDestination, HWND hwndSource, out nint phThumbnailId);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmrendergesture
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmRenderGesture(GESTURE_TYPE gt, uint cContacts, in uint pdwPointerID, in FoundationPOINT pPoints);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetdxframeduration
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetDxFrameDuration(HWND hwnd, int cRefreshes);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmseticoniclivepreviewbitmap
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmSetIconicLivePreviewBitmap(HWND hwnd, HBITMAP hbmp, nint/* nint */ pptClient, uint dwSITFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmseticonicthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmSetIconicThumbnail(HWND hwnd, HBITMAP hbmp, uint dwSITFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetpresentparameters
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetPresentParameters(HWND hwnd, ref DWM_PRESENT_PARAMETERS pPresentParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetwindowattribute
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetWindowAttribute(HWND hwnd, uint dwAttribute, nint pvAttribute, uint cbAttribute);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmshowcontact
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmShowContact(uint dwPointerID, DWM_SHOWCONTACT eShowContact);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmtethercontact
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmTetherContact(uint dwPointerID, [MarshalAs(UnmanagedType.U4)] bool fEnable, in FoundationPOINT ptTether);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmtransitionownedwindow
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmTransitionOwnedWindow(HWND hwnd, DWMTRANSITION_OWNEDWINDOW_TARGET target);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmunregisterthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmUnregisterThumbnail(nint hThumbnailId);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmupdatethumbnailproperties
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmUpdateThumbnailProperties(nint hThumbnailId, in DWM_THUMBNAIL_PROPERTIES ptnProperties);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-dwritecreatefactory
    [LibraryImport("DWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, in Guid iid, out nint factory);
    
    [LibraryImport("dxcompiler")]
    [PreserveSig]
    public static partial HRESULT DxcCreateInstance(in Guid rclsid, in Guid riid, out nint ppv);
    
    [LibraryImport("dxcompiler")]
    [PreserveSig]
    public static partial HRESULT DxcCreateInstance2(IMalloc pMalloc, in Guid rclsid, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/dxcore/dxcore/nf-dxcore-dxcorecreateadapterfactory
    [LibraryImport("DXCORE")]
    [PreserveSig]
    public static partial HRESULT DXCoreCreateAdapterFactory(in Guid riid, out nint ppvFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgideclareadapterremovalsupport
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT DXGIDeclareAdapterRemovalSupport();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgidisablevblankvirtualization
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT DXGIDisableVBlankVirtualization();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-dxgigetdebuginterface1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT DXGIGetDebugInterface1(uint Flags, in Guid riid, out nint pDebug);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathArc(ref GpPath path, float x, float y, float width, float height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathArcI(ref GpPath path, int x, int y, int width, int height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathBezier(ref GpPath path, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathBezierI(ref GpPath path, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathBeziers(ref GpPath path, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathBeziersI(ref GpPath path, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathClosedCurve(ref GpPath path, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathClosedCurve2(ref GpPath path, in PointF points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathClosedCurve2I(ref GpPath path, in GdiPlusPoint points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathClosedCurveI(ref GpPath path, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurve(ref GpPath path, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurve2(ref GpPath path, in PointF points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurve2I(ref GpPath path, in GdiPlusPoint points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurve3(ref GpPath path, in PointF points, int count, int offset, int numberOfSegments, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurve3I(ref GpPath path, in GdiPlusPoint points, int count, int offset, int numberOfSegments, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathCurveI(ref GpPath path, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathEllipse(ref GpPath path, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathEllipseI(ref GpPath path, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathLine(ref GpPath path, float x1, float y1, float x2, float y2);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathLine2(ref GpPath path, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathLine2I(ref GpPath path, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathLineI(ref GpPath path, int x1, int y1, int x2, int y2);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathPath(ref GpPath path, in GpPath addingPath, [MarshalAs(UnmanagedType.U4)] bool connect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathPie(ref GpPath path, float x, float y, float width, float height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathPieI(ref GpPath path, int x, int y, int width, int height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathPolygon(ref GpPath path, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathPolygonI(ref GpPath path, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathRectangle(ref GpPath path, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathRectangleI(ref GpPath path, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathRectangles(ref GpPath path, in RectF rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathRectanglesI(ref GpPath path, in GdiPlusRect rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathString(ref GpPath path, PWSTR @string, int length, in GpFontFamily family, int style, float emSize, in RectF layoutRect, in GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipAddPathStringI(ref GpPath path, PWSTR @string, int length, in GpFontFamily family, int style, float emSize, in GdiPlusRect layoutRect, in GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial void GdipAlloc(nuint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBeginContainer(ref GpGraphics graphics, in RectF dstrect, in RectF srcrect, Unit unit, ref uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBeginContainer2(ref GpGraphics graphics, ref uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBeginContainerI(ref GpGraphics graphics, in GdiPlusRect dstrect, in GdiPlusRect srcrect, Unit unit, ref uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapApplyEffect(ref GpBitmap bitmap, ref CGpEffect effect, ref FoundationRECT roi, [MarshalAs(UnmanagedType.U4)] bool useAuxData, out nint auxData, ref int auxDataSize);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapConvertFormat(ref GpBitmap pInputBitmap, int format, DitherType dithertype, PaletteType palettetype, ref ColorPalette palette, float alphaThresholdPercent);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapCreateApplyEffect(ref GpBitmap inputBitmaps, int numInputs, ref CGpEffect effect, ref FoundationRECT roi, ref FoundationRECT outputRect, ref GpBitmap outputBitmap, [MarshalAs(UnmanagedType.U4)] bool useAuxData, out nint auxData, ref int auxDataSize);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapGetHistogram(ref GpBitmap bitmap, HistogramFormat format, uint NumberOfEntries, out uint channel0, out uint channel1, out uint channel2, out uint channel3);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapGetHistogramSize(HistogramFormat format, ref uint NumberOfEntries);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapGetPixel(ref GpBitmap bitmap, int x, int y, ref uint color);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapLockBits(ref GpBitmap bitmap, in GdiPlusRect rect, uint flags, int format, ref BitmapData lockedBitmapData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapSetPixel(ref GpBitmap bitmap, int x, int y, uint color);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapSetResolution(ref GpBitmap bitmap, float xdpi, float ydpi);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipBitmapUnlockBits(ref GpBitmap bitmap, ref BitmapData lockedBitmapData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipClearPathMarkers(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneBitmapArea(float x, float y, float width, float height, int format, ref GpBitmap srcBitmap, ref GpBitmap dstBitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneBitmapAreaI(int x, int y, int width, int height, int format, ref GpBitmap srcBitmap, ref GpBitmap dstBitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneBrush(ref GpBrush brush, ref GpBrush cloneBrush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneCustomLineCap(ref GpCustomLineCap customCap, ref GpCustomLineCap clonedCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneFont(ref GpFont font, ref GpFont cloneFont);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneFontFamily(ref GpFontFamily fontFamily, ref GpFontFamily clonedFontFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneImage(ref GpImage image, ref GpImage cloneImage);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneImageAttributes(in GpImageAttributes imageattr, ref GpImageAttributes cloneImageattr);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneMatrix(ref Matrix matrix, ref Matrix cloneMatrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipClonePath(ref GpPath path, ref GpPath clonePath);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipClonePen(ref GpPen pen, ref GpPen clonepen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneRegion(ref GpRegion region, ref GpRegion cloneRegion);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCloneStringFormat(in GpStringFormat format, ref GpStringFormat newFormat);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipClosePathFigure(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipClosePathFigures(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCombineRegionPath(ref GpRegion region, ref GpPath path, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCombineRegionRect(ref GpRegion region, in RectF rect, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCombineRegionRectI(ref GpRegion region, in GdiPlusRect rect, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCombineRegionRegion(ref GpRegion region, ref GpRegion region2, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipComment(ref GpGraphics graphics, uint sizeData, nint /* byte array */ data);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipConvertToEmfPlus(in GpGraphics refGraphics, ref GpMetafile metafile, ref int conversionFailureFlag, EmfType emfType, PWSTR description, ref GpMetafile out_metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipConvertToEmfPlusToFile(in GpGraphics refGraphics, ref GpMetafile metafile, ref int conversionFailureFlag, PWSTR filename, EmfType emfType, PWSTR description, ref GpMetafile out_metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipConvertToEmfPlusToStream(in GpGraphics refGraphics, ref GpMetafile metafile, ref int conversionFailureFlag, IStream stream, EmfType emfType, PWSTR description, ref GpMetafile out_metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateAdjustableArrowCap(float height, float width, [MarshalAs(UnmanagedType.U4)] bool isFilled, ref GpAdjustableArrowCap cap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromDirectDrawSurface(IDirectDrawSurface7 surface, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromFile(PWSTR filename, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromFileICM(PWSTR filename, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromGdiDib(in BITMAPINFO gdiBitmapInfo, nint gdiBitmapData, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromGraphics(int width, int height, ref GpGraphics target, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromHBITMAP(HBITMAP hbm, HPALETTE hpal, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromHICON(HICON hicon, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromResource(HINSTANCE hInstance, PWSTR lpBitmapName, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromScan0(int width, int height, int stride, int format, nint /* byte array */ scan0, out GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromStream(IStream stream, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateBitmapFromStreamICM(IStream stream, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateCachedBitmap(ref GpBitmap bitmap, ref GpGraphics graphics, ref GpCachedBitmap cachedBitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateCustomLineCap(ref GpPath fillPath, ref GpPath strokePath, LineCap baseCap, float baseInset, ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateEffect(Guid guid, ref CGpEffect effect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFont(in GpFontFamily fontFamily, float emSize, int style, Unit unit, ref GpFont font);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFontFamilyFromName(PWSTR name, ref GpFontCollection fontCollection, ref GpFontFamily fontFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFontFromDC(HDC hdc, ref GpFont font);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFontFromLogfontA(HDC hdc, in LOGFONTA logfont, ref GpFont font);
    
    [LibraryImport("gdiplus", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial Status GdipCreateFontFromLogfontW(HDC hdc, in LOGFONTW logfont, ref GpFont font);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFromHDC(HDC hdc, ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFromHDC2(HDC hdc, HANDLE hDevice, ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFromHWND(HWND hwnd, ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateFromHWNDICM(HWND hwnd, ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial HPALETTE GdipCreateHalftonePalette();
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateHatchBrush(HatchStyle hatchstyle, uint forecol, uint backcol, ref GpHatch brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateHBITMAPFromBitmap(ref GpBitmap bitmap, ref HBITMAP hbmReturn, uint background);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateHICONFromBitmap(ref GpBitmap bitmap, ref HICON hbmReturn);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateImageAttributes(ref GpImageAttributes imageattr);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrush(in PointF point1, in PointF point2, uint color1, uint color2, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrushFromRect(in RectF rect, uint color1, uint color2, LinearGradientMode mode, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrushFromRectI(in GdiPlusRect rect, uint color1, uint color2, LinearGradientMode mode, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrushFromRectWithAngle(in RectF rect, uint color1, uint color2, float angle, [MarshalAs(UnmanagedType.U4)] bool isAngleScalable, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrushFromRectWithAngleI(in GdiPlusRect rect, uint color1, uint color2, float angle, [MarshalAs(UnmanagedType.U4)] bool isAngleScalable, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateLineBrushI(in GdiPlusPoint point1, in GdiPlusPoint point2, uint color1, uint color2, WrapMode wrapMode, ref GpLineGradient lineGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMatrix(ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMatrix2(float m11, float m12, float m21, float m22, float dx, float dy, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMatrix3(in RectF rect, in PointF dstplg, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMatrix3I(in GdiPlusRect rect, in GdiPlusPoint dstplg, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMetafileFromEmf(HENHMETAFILE hEmf, [MarshalAs(UnmanagedType.U4)] bool deleteEmf, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMetafileFromFile(PWSTR file, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMetafileFromStream(IStream stream, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMetafileFromWmf(HMETAFILE hWmf, [MarshalAs(UnmanagedType.U4)] bool deleteWmf, in WmfPlaceableFileHeader wmfPlaceableFileHeader, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateMetafileFromWmfFile(PWSTR file, in WmfPlaceableFileHeader wmfPlaceableFileHeader, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePath(FillMode brushMode, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePath2(in PointF param0, nint /* byte array */ param1, int param2, FillMode param3, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePath2I(in GdiPlusPoint param0, nint /* byte array */ param1, int param2, FillMode param3, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePathGradient(in PointF points, int count, WrapMode wrapMode, ref GpPathGradient polyGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePathGradientFromPath(in GpPath path, ref GpPathGradient polyGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePathGradientI(in GdiPlusPoint points, int count, WrapMode wrapMode, ref GpPathGradient polyGradient);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePathIter(ref GpPathIterator iterator, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePen1(uint color, float width, Unit unit, ref GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreatePen2(ref GpBrush brush, float width, Unit unit, ref GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegion(ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegionHrgn(HRGN hRgn, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegionPath(ref GpPath path, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegionRect(in RectF rect, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegionRectI(in GdiPlusRect rect, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateRegionRgnData(nint /* byte array */ regionData, int size, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateSolidFill(uint color, ref GpSolidFill brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateStreamOnFile(PWSTR filename, uint access, out IStream stream);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateStringFormat(int formatAttributes, ushort language, ref GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateTexture(ref GpImage image, WrapMode wrapmode, ref GpTexture texture);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateTexture2(ref GpImage image, WrapMode wrapmode, float x, float y, float width, float height, ref GpTexture texture);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateTexture2I(ref GpImage image, WrapMode wrapmode, int x, int y, int width, int height, ref GpTexture texture);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateTextureIA(ref GpImage image, in GpImageAttributes imageAttributes, float x, float y, float width, float height, ref GpTexture texture);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipCreateTextureIAI(ref GpImage image, in GpImageAttributes imageAttributes, int x, int y, int width, int height, ref GpTexture texture);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteBrush(ref GpBrush brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteCachedBitmap(ref GpCachedBitmap cachedBitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteCustomLineCap(ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteEffect(ref CGpEffect effect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteFont(ref GpFont font);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteFontFamily(ref GpFontFamily fontFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteGraphics(ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteMatrix(ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeletePath(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeletePathIter(ref GpPathIterator iterator);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeletePen(ref GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeletePrivateFontCollection(ref GpFontCollection fontCollection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteRegion(ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDeleteStringFormat(ref GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDisposeImage(ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDisposeImageAttributes(ref GpImageAttributes imageattr);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawArc(ref GpGraphics graphics, ref GpPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawArcI(ref GpGraphics graphics, ref GpPen pen, int x, int y, int width, int height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawBezier(ref GpGraphics graphics, ref GpPen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawBezierI(ref GpGraphics graphics, ref GpPen pen, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawBeziers(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawBeziersI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCachedBitmap(ref GpGraphics graphics, ref GpCachedBitmap cachedBitmap, int x, int y);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawClosedCurve(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawClosedCurve2(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawClosedCurve2I(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawClosedCurveI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurve(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurve2(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurve2I(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurve3(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count, int offset, int numberOfSegments, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurve3I(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count, int offset, int numberOfSegments, float tension);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawCurveI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawDriverString(ref GpGraphics graphics, in ushort text, int length, in GpFont font, in GpBrush brush, in PointF positions, int flags, in Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawEllipse(ref GpGraphics graphics, ref GpPen pen, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawEllipseI(ref GpGraphics graphics, ref GpPen pen, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImage(ref GpGraphics graphics, ref GpImage image, float x, float y);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageFX(ref GpGraphics graphics, ref GpImage image, ref RectF source, ref Matrix xForm, ref CGpEffect effect, ref GpImageAttributes imageAttributes, Unit srcUnit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageI(ref GpGraphics graphics, ref GpImage image, int x, int y);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePointRect(ref GpGraphics graphics, ref GpImage image, float x, float y, float srcx, float srcy, float srcwidth, float srcheight, Unit srcUnit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePointRectI(ref GpGraphics graphics, ref GpImage image, int x, int y, int srcx, int srcy, int srcwidth, int srcheight, Unit srcUnit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePoints(ref GpGraphics graphics, ref GpImage image, in PointF dstpoints, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePointsI(ref GpGraphics graphics, ref GpImage image, in GdiPlusPoint dstpoints, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePointsRect(ref GpGraphics graphics, ref GpImage image, in PointF points, int count, float srcx, float srcy, float srcwidth, float srcheight, Unit srcUnit, in GpImageAttributes imageAttributes, nint callback, nint callbackData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImagePointsRectI(ref GpGraphics graphics, ref GpImage image, in GdiPlusPoint points, int count, int srcx, int srcy, int srcwidth, int srcheight, Unit srcUnit, in GpImageAttributes imageAttributes, nint callback, nint callbackData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageRect(ref GpGraphics graphics, ref GpImage image, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageRectI(ref GpGraphics graphics, ref GpImage image, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageRectRect(ref GpGraphics graphics, ref GpImage image, float dstx, float dsty, float dstwidth, float dstheight, float srcx, float srcy, float srcwidth, float srcheight, Unit srcUnit, in GpImageAttributes imageAttributes, nint callback, nint callbackData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawImageRectRectI(ref GpGraphics graphics, ref GpImage image, int dstx, int dsty, int dstwidth, int dstheight, int srcx, int srcy, int srcwidth, int srcheight, Unit srcUnit, in GpImageAttributes imageAttributes, nint callback, nint callbackData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawLine(ref GpGraphics graphics, ref GpPen pen, float x1, float y1, float x2, float y2);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawLineI(ref GpGraphics graphics, ref GpPen pen, int x1, int y1, int x2, int y2);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawLines(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawLinesI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawPath(ref GpGraphics graphics, ref GpPen pen, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawPie(ref GpGraphics graphics, ref GpPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawPieI(ref GpGraphics graphics, ref GpPen pen, int x, int y, int width, int height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawPolygon(ref GpGraphics graphics, ref GpPen pen, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawPolygonI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawRectangle(ref GpGraphics graphics, ref GpPen pen, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawRectangleI(ref GpGraphics graphics, ref GpPen pen, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawRectangles(ref GpGraphics graphics, ref GpPen pen, in RectF rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawRectanglesI(ref GpGraphics graphics, ref GpPen pen, in GdiPlusRect rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipDrawString(ref GpGraphics graphics, PWSTR @string, int length, in GpFont font, in RectF layoutRect, in GpStringFormat stringFormat, in GpBrush brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial uint GdipEmfToWmfBits(HENHMETAFILE hemf, uint cbData16, nint /* byte array */ pData16, int iMapMode, int eFlags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEndContainer(ref GpGraphics graphics, uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestPoint(ref GpGraphics graphics, in GpMetafile metafile, in PointF destPoint, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestPointI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusPoint destPoint, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestPoints(ref GpGraphics graphics, in GpMetafile metafile, in PointF destPoints, int count, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestPointsI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusPoint destPoints, int count, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestRect(ref GpGraphics graphics, in GpMetafile metafile, in RectF destRect, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileDestRectI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusRect destRect, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestPoint(ref GpGraphics graphics, in GpMetafile metafile, in PointF destPoint, in RectF srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestPointI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusPoint destPoint, in GdiPlusRect srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestPoints(ref GpGraphics graphics, in GpMetafile metafile, in PointF destPoints, int count, in RectF srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestPointsI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusPoint destPoints, int count, in GdiPlusRect srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestRect(ref GpGraphics graphics, in GpMetafile metafile, in RectF destRect, in RectF srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipEnumerateMetafileSrcRectDestRectI(ref GpGraphics graphics, in GpMetafile metafile, in GdiPlusRect destRect, in GdiPlusRect srcRect, Unit srcUnit, nint callback, nint callbackData, in GpImageAttributes imageAttributes);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillClosedCurve(ref GpGraphics graphics, ref GpBrush brush, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillClosedCurve2(ref GpGraphics graphics, ref GpBrush brush, in PointF points, int count, float tension, FillMode fillMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillClosedCurve2I(ref GpGraphics graphics, ref GpBrush brush, in GdiPlusPoint points, int count, float tension, FillMode fillMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillClosedCurveI(ref GpGraphics graphics, ref GpBrush brush, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillEllipse(ref GpGraphics graphics, ref GpBrush brush, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillEllipseI(ref GpGraphics graphics, ref GpBrush brush, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPath(ref GpGraphics graphics, ref GpBrush brush, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPie(ref GpGraphics graphics, ref GpBrush brush, float x, float y, float width, float height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPieI(ref GpGraphics graphics, ref GpBrush brush, int x, int y, int width, int height, float startAngle, float sweepAngle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPolygon(ref GpGraphics graphics, ref GpBrush brush, in PointF points, int count, FillMode fillMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPolygon2(ref GpGraphics graphics, ref GpBrush brush, in PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPolygon2I(ref GpGraphics graphics, ref GpBrush brush, in GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillPolygonI(ref GpGraphics graphics, ref GpBrush brush, in GdiPlusPoint points, int count, FillMode fillMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillRectangle(ref GpGraphics graphics, ref GpBrush brush, float x, float y, float width, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillRectangleI(ref GpGraphics graphics, ref GpBrush brush, int x, int y, int width, int height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillRectangles(ref GpGraphics graphics, ref GpBrush brush, in RectF rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillRectanglesI(ref GpGraphics graphics, ref GpBrush brush, in GdiPlusRect rects, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFillRegion(ref GpGraphics graphics, ref GpBrush brush, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFindFirstImageItem(ref GpImage image, ref ImageItemData item);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFindNextImageItem(ref GpImage image, ref ImageItemData item);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFlattenPath(ref GpPath path, ref Matrix matrix, float flatness);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipFlush(ref GpGraphics graphics, FlushIntention intention);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial void GdipFree(nint ptr);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetAdjustableArrowCapFillState(ref GpAdjustableArrowCap cap, [MarshalAs(UnmanagedType.U4)] ref bool fillState);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetAdjustableArrowCapHeight(ref GpAdjustableArrowCap cap, ref float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetAdjustableArrowCapMiddleInset(ref GpAdjustableArrowCap cap, ref float middleInset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetAdjustableArrowCapWidth(ref GpAdjustableArrowCap cap, ref float width);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetAllPropertyItems(ref GpImage image, uint totalBufferSize, uint numProperties, ref PropertyItem allItems);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetBrushType(ref GpBrush brush, ref BrushType type);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCellAscent(in GpFontFamily family, int style, ref ushort CellAscent);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCellDescent(in GpFontFamily family, int style, ref ushort CellDescent);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetClip(ref GpGraphics graphics, ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetClipBounds(ref GpGraphics graphics, ref RectF rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetClipBoundsI(ref GpGraphics graphics, ref GdiPlusRect rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCompositingMode(ref GpGraphics graphics, ref CompositingMode compositingMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCompositingQuality(ref GpGraphics graphics, ref CompositingQuality compositingQuality);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapBaseCap(ref GpCustomLineCap customCap, ref LineCap baseCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapBaseInset(ref GpCustomLineCap customCap, ref float inset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapStrokeCaps(ref GpCustomLineCap customCap, ref LineCap startCap, ref LineCap endCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapStrokeJoin(ref GpCustomLineCap customCap, ref LineJoin lineJoin);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapType(ref GpCustomLineCap customCap, ref CustomLineCapType capType);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetCustomLineCapWidthScale(ref GpCustomLineCap customCap, ref float widthScale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetDC(ref GpGraphics graphics, ref HDC hdc);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetDpiX(ref GpGraphics graphics, ref float dpi);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetDpiY(ref GpGraphics graphics, ref float dpi);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetEffectParameters(ref CGpEffect effect, ref uint size, nint @params);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetEffectParameterSize(ref CGpEffect effect, ref uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetEmHeight(in GpFontFamily family, int style, ref ushort EmHeight);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetEncoderParameterList(ref GpImage image, in Guid clsidEncoder, uint size, ref EncoderParameters buffer);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetEncoderParameterListSize(ref GpImage image, in Guid clsidEncoder, ref uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFamily(ref GpFont font, ref GpFontFamily family);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFamilyName(in GpFontFamily family, out PWSTR name, ushort language);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontCollectionFamilyCount(ref GpFontCollection fontCollection, ref int numFound);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontCollectionFamilyList(in GpFontCollection fontCollection, int numSought, out GpFontFamily gpfamilies, out int numFound);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontHeight(in GpFont font, in GpGraphics graphics, ref float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontHeightGivenDPI(in GpFont font, float dpi, ref float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontSize(ref GpFont font, ref float size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontStyle(ref GpFont font, ref int style);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetFontUnit(ref GpFont font, ref Unit unit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetGenericFontFamilyMonospace(ref GpFontFamily nativeFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetGenericFontFamilySansSerif(ref GpFontFamily nativeFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetGenericFontFamilySerif(ref GpFontFamily nativeFamily);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetHatchBackgroundColor(ref GpHatch brush, ref uint backcol);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetHatchForegroundColor(ref GpHatch brush, ref uint forecol);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetHatchStyle(ref GpHatch brush, ref HatchStyle hatchstyle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetHemfFromMetafile(ref GpMetafile metafile, ref HENHMETAFILE hEmf);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageAttributesAdjustedPalette(ref GpImageAttributes imageAttr, ref ColorPalette colorPalette, ColorAdjustType colorAdjustType);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageBounds(ref GpImage image, ref RectF srcRect, ref Unit srcUnit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageDecoders(uint numDecoders, uint size, out ImageCodecInfo decoders);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageDecodersSize(out uint numDecoders, out uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageDimension(ref GpImage image, ref float width, ref float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageEncoders(uint numEncoders, uint size, out ImageCodecInfo encoders);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageEncodersSize(out uint numEncoders, out uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageFlags(ref GpImage image, ref uint flags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageGraphicsContext(ref GpImage image, ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageHeight(ref GpImage image, ref uint height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageHorizontalResolution(ref GpImage image, ref float resolution);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageItemData(ref GpImage image, ref ImageItemData item);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImagePalette(ref GpImage image, ref ColorPalette palette, int size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImagePaletteSize(ref GpImage image, ref int size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImagePixelFormat(ref GpImage image, ref int format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageRawFormat(ref GpImage image, ref Guid format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageThumbnail(ref GpImage image, uint thumbWidth, uint thumbHeight, ref GpImage thumbImage, nint callback, nint callbackData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageType(ref GpImage image, ref ImageType type);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageVerticalResolution(ref GpImage image, ref float resolution);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetImageWidth(ref GpImage image, ref uint width);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetInterpolationMode(ref GpGraphics graphics, ref InterpolationMode interpolationMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineBlend(ref GpLineGradient brush, ref float blend, ref float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineBlendCount(ref GpLineGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineColors(ref GpLineGradient brush, ref uint colors);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineGammaCorrection(ref GpLineGradient brush, [MarshalAs(UnmanagedType.U4)] ref bool useGammaCorrection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLinePresetBlend(ref GpLineGradient brush, ref uint blend, ref float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLinePresetBlendCount(ref GpLineGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineRect(ref GpLineGradient brush, ref RectF rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineRectI(ref GpLineGradient brush, ref GdiPlusRect rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineSpacing(in GpFontFamily family, int style, ref ushort LineSpacing);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineTransform(ref GpLineGradient brush, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLineWrapMode(ref GpLineGradient brush, ref WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetLogFontA(ref GpFont font, ref GpGraphics graphics, ref LOGFONTA logfontA);
    
    [LibraryImport("gdiplus", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial Status GdipGetLogFontW(ref GpFont font, ref GpGraphics graphics, ref LOGFONTW logfontW);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMatrixElements(in Matrix matrix, ref float matrixOut);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileDownLevelRasterizationLimit(in GpMetafile metafile, ref uint metafileRasterizationLimitDpi);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileHeaderFromEmf(HENHMETAFILE hEmf, ref MetafileHeader header);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileHeaderFromFile(PWSTR filename, ref MetafileHeader header);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileHeaderFromMetafile(ref GpMetafile metafile, ref MetafileHeader header);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileHeaderFromStream(IStream stream, ref MetafileHeader header);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetMetafileHeaderFromWmf(HMETAFILE hWmf, in WmfPlaceableFileHeader wmfPlaceableFileHeader, ref MetafileHeader header);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetNearestColor(ref GpGraphics graphics, ref uint argb);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPageScale(ref GpGraphics graphics, ref float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPageUnit(ref GpGraphics graphics, ref Unit unit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathData(ref GpPath path, ref PathData pathData);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathFillMode(ref GpPath path, ref FillMode fillmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientBlend(ref GpPathGradient brush, ref float blend, ref float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientBlendCount(ref GpPathGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientCenterColor(ref GpPathGradient brush, ref uint colors);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientCenterPoint(ref GpPathGradient brush, ref PointF points);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientCenterPointI(ref GpPathGradient brush, ref GdiPlusPoint points);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientFocusScales(ref GpPathGradient brush, ref float xScale, ref float yScale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientGammaCorrection(ref GpPathGradient brush, [MarshalAs(UnmanagedType.U4)] ref bool useGammaCorrection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientPath(ref GpPathGradient brush, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientPointCount(ref GpPathGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientPresetBlend(ref GpPathGradient brush, ref uint blend, ref float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientPresetBlendCount(ref GpPathGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientRect(ref GpPathGradient brush, ref RectF rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientRectI(ref GpPathGradient brush, ref GdiPlusRect rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientSurroundColorCount(ref GpPathGradient brush, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientSurroundColorsWithCount(in GpPathGradient brush, out uint color, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientTransform(ref GpPathGradient brush, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathGradientWrapMode(ref GpPathGradient brush, ref WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathLastPoint(ref GpPath path, ref PointF lastPoint);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathPoints(ref GpPath param0, ref PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathPointsI(ref GpPath param0, ref GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathTypes(in GpPath path, nint /* byte array */ types, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathWorldBounds(ref GpPath path, ref RectF bounds, in Matrix matrix, in GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPathWorldBoundsI(ref GpPath path, ref GdiPlusRect bounds, in Matrix matrix, in GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenBrushFill(ref GpPen pen, ref GpBrush brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenColor(ref GpPen pen, ref uint argb);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenCompoundArray(ref GpPen pen, ref float dash, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenCompoundCount(ref GpPen pen, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenCustomEndCap(ref GpPen pen, ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenCustomStartCap(ref GpPen pen, ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenDashArray(ref GpPen pen, ref float dash, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenDashCap197819(ref GpPen pen, ref DashCap dashCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenDashCount(ref GpPen pen, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenDashOffset(ref GpPen pen, ref float offset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenDashStyle(ref GpPen pen, ref DashStyle dashstyle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenEndCap(ref GpPen pen, ref LineCap endCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenFillType(ref GpPen pen, ref PenType type);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenLineJoin(ref GpPen pen, ref LineJoin lineJoin);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenMiterLimit(ref GpPen pen, ref float miterLimit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenMode(ref GpPen pen, ref PenAlignment penMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenStartCap(ref GpPen pen, ref LineCap startCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenTransform(ref GpPen pen, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenUnit(ref GpPen pen, ref Unit unit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPenWidth(ref GpPen pen, ref float width);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPixelOffsetMode(ref GpGraphics graphics, ref PixelOffsetMode pixelOffsetMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPointCount(ref GpPath path, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPropertyCount(ref GpImage image, ref uint numOfProperty);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPropertyIdList(ref GpImage image, uint numOfProperty, ref uint list);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPropertyItem(ref GpImage image, uint propId, uint propSize, ref PropertyItem buffer);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPropertyItemSize(ref GpImage image, uint propId, ref uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetPropertySize(ref GpImage image, ref uint totalBufferSize, ref uint numProperties);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionBounds(ref GpRegion region, ref GpGraphics graphics, ref RectF rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionBoundsI(ref GpRegion region, ref GpGraphics graphics, ref GdiPlusRect rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionData(ref GpRegion region, nint /* byte array */ buffer, uint bufferSize, nint/* nint */ sizeFilled);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionDataSize(ref GpRegion region, ref uint bufferSize);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionHRgn(ref GpRegion region, ref GpGraphics graphics, ref HRGN hRgn);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionScans(ref GpRegion region, ref RectF rects, ref int count, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionScansCount(ref GpRegion region, ref uint count, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRegionScansI(ref GpRegion region, ref GdiPlusRect rects, ref int count, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetRenderingOrigin(ref GpGraphics graphics, ref int x, ref int y);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetSmoothingMode(ref GpGraphics graphics, ref SmoothingMode smoothingMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetSolidFillColor(ref GpSolidFill brush, ref uint color);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatAlign(in GpStringFormat format, ref StringAlignment align);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatDigitSubstitution(in GpStringFormat format, ref ushort language, ref StringDigitSubstitute substitute);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatFlags(in GpStringFormat format, ref int flags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatHotkeyPrefix(in GpStringFormat format, ref int hotkeyPrefix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatLineAlign(in GpStringFormat format, ref StringAlignment align);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatMeasurableCharacterRangeCount(in GpStringFormat format, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatTabStopCount(in GpStringFormat format, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatTabStops(in GpStringFormat format, int count, ref float firstTabOffset, ref float tabStops);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetStringFormatTrimming(in GpStringFormat format, ref StringTrimming trimming);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetTextContrast(ref GpGraphics graphics, ref uint contrast);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetTextRenderingHint(ref GpGraphics graphics, ref TextRenderingHint mode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetTextureImage(ref GpTexture brush, ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetTextureTransform(ref GpTexture brush, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetTextureWrapMode(ref GpTexture brush, ref WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetVisibleClipBounds(ref GpGraphics graphics, ref RectF rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetVisibleClipBoundsI(ref GpGraphics graphics, ref GdiPlusRect rect);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGetWorldTransform(ref GpGraphics graphics, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGraphicsClear(ref GpGraphics graphics, uint color);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipGraphicsSetAbort(ref GpGraphics pGraphics, GdiplusAbort pIAbort);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageForceValidation(ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageGetFrameCount(ref GpImage image, in Guid dimensionID, ref uint count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageGetFrameDimensionsCount(ref GpImage image, ref uint count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageGetFrameDimensionsList(ref GpImage image, ref Guid dimensionIDs, uint count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageRotateFlip(ref GpImage image, RotateFlipType rfType);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageSelectActiveFrame(ref GpImage image, in Guid dimensionID, uint frameIndex);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipImageSetAbort(ref GpImage pImage, GdiplusAbort pIAbort);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipInitializePalette(ref ColorPalette palette, PaletteType palettetype, int optimalColors, [MarshalAs(UnmanagedType.U4)] bool useTransparentColor, ref GpBitmap bitmap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipInvertMatrix(ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsClipEmpty(ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsEmptyRegion(ref GpRegion region, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsEqualRegion(ref GpRegion region, ref GpRegion region2, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsInfiniteRegion(ref GpRegion region, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsMatrixEqual(in Matrix matrix, in Matrix matrix2, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsMatrixIdentity(in Matrix matrix, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsMatrixInvertible(in Matrix matrix, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsOutlineVisiblePathPoint(ref GpPath path, float x, float y, ref GpPen pen, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsOutlineVisiblePathPointI(ref GpPath path, int x, int y, ref GpPen pen, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsStyleAvailable(in GpFontFamily family, int style, [MarshalAs(UnmanagedType.U4)] ref bool IsStyleAvailable);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleClipEmpty(ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisiblePathPoint(ref GpPath path, float x, float y, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisiblePathPointI(ref GpPath path, int x, int y, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisiblePoint(ref GpGraphics graphics, float x, float y, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisiblePointI(ref GpGraphics graphics, int x, int y, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRect(ref GpGraphics graphics, float x, float y, float width, float height, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRectI(ref GpGraphics graphics, int x, int y, int width, int height, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRegionPoint(ref GpRegion region, float x, float y, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRegionPointI(ref GpRegion region, int x, int y, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRegionRect(ref GpRegion region, float x, float y, float width, float height, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipIsVisibleRegionRectI(ref GpRegion region, int x, int y, int width, int height, ref GpGraphics graphics, [MarshalAs(UnmanagedType.U4)] ref bool result);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipLoadImageFromFile(PWSTR filename, ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipLoadImageFromFileICM(PWSTR filename, ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipLoadImageFromStream(IStream stream, ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipLoadImageFromStreamICM(IStream stream, ref GpImage image);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdiplusNotificationHook(ref nuint token);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial void GdiplusNotificationUnhook(nuint token);
    
    [LibraryImport("gdiplus")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial void GdiplusShutdown(nuint token);
    
    [LibraryImport("gdiplus")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial Status GdiplusStartup(ref nuint token, in GdiplusStartupInput input, ref GdiplusStartupOutput output);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMeasureCharacterRanges(ref GpGraphics graphics, PWSTR @string, int length, in GpFont font, in RectF layoutRect, in GpStringFormat stringFormat, int regionCount, ref GpRegion regions);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMeasureDriverString(ref GpGraphics graphics, in ushort text, int length, in GpFont font, in PointF positions, int flags, in Matrix matrix, ref RectF boundingBox);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMeasureString(ref GpGraphics graphics, PWSTR @string, int length, in GpFont font, in RectF layoutRect, in GpStringFormat stringFormat, ref RectF boundingBox, ref int codepointsFitted, ref int linesFilled);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyLineTransform(ref GpLineGradient brush, in Matrix matrix, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyMatrix(ref Matrix matrix, ref Matrix matrix2, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyPathGradientTransform(ref GpPathGradient brush, in Matrix matrix, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyPenTransform(ref GpPen pen, in Matrix matrix, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyTextureTransform(ref GpTexture brush, in Matrix matrix, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipMultiplyWorldTransform(ref GpGraphics graphics, in Matrix matrix, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipNewInstalledFontCollection(ref GpFontCollection fontCollection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipNewPrivateFontCollection(ref GpFontCollection fontCollection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterCopyData(ref GpPathIterator iterator, out int resultCount, out PointF points, nint /* byte array */ types, int startIndex, int endIndex);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterEnumerate(ref GpPathIterator iterator, out int resultCount, out PointF points, nint /* byte array */ types, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterGetCount(ref GpPathIterator iterator, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterGetSubpathCount(ref GpPathIterator iterator, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterHasCurve(ref GpPathIterator iterator, [MarshalAs(UnmanagedType.U4)] ref bool hasCurve);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterIsValid(ref GpPathIterator iterator, [MarshalAs(UnmanagedType.U4)] ref bool valid);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterNextMarker(ref GpPathIterator iterator, ref int resultCount, ref int startIndex, ref int endIndex);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterNextMarkerPath(ref GpPathIterator iterator, ref int resultCount, ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterNextPathType(ref GpPathIterator iterator, out int resultCount, nint /* byte array */ pathType, out int startIndex, out int endIndex);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterNextSubpath(ref GpPathIterator iterator, ref int resultCount, ref int startIndex, ref int endIndex, [MarshalAs(UnmanagedType.U4)] ref bool isClosed);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterNextSubpathPath(ref GpPathIterator iterator, ref int resultCount, ref GpPath path, [MarshalAs(UnmanagedType.U4)] ref bool isClosed);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPathIterRewind(ref GpPathIterator iterator);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPlayMetafileRecord(in GpMetafile metafile, EmfPlusRecordType recordType, uint flags, uint dataSize, nint /* byte array */ data);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPrivateAddFontFile(ref GpFontCollection fontCollection, PWSTR filename);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipPrivateAddMemoryFont(ref GpFontCollection fontCollection, nint memory, int length);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafile(HDC referenceHdc, EmfType type, in RectF frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafileFileName(PWSTR fileName, HDC referenceHdc, EmfType type, in RectF frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafileFileNameI(PWSTR fileName, HDC referenceHdc, EmfType type, in GdiPlusRect frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafileI(HDC referenceHdc, EmfType type, in GdiPlusRect frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafileStream(IStream stream, HDC referenceHdc, EmfType type, in RectF frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRecordMetafileStreamI(IStream stream, HDC referenceHdc, EmfType type, in GdiPlusRect frameRect, MetafileFrameUnit frameUnit, PWSTR description, ref GpMetafile metafile);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipReleaseDC(ref GpGraphics graphics, HDC hdc);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRemovePropertyItem(ref GpImage image, uint propId);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetClip(ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetImageAttributes(ref GpImageAttributes imageattr, ColorAdjustType type);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetLineTransform(ref GpLineGradient brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetPageTransform(ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetPath(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetPathGradientTransform(ref GpPathGradient brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetPenTransform(ref GpPen pen);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetTextureTransform(ref GpTexture brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipResetWorldTransform(ref GpGraphics graphics);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRestoreGraphics(ref GpGraphics graphics, uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipReversePath(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotateLineTransform(ref GpLineGradient brush, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotateMatrix(ref Matrix matrix, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotatePathGradientTransform(ref GpPathGradient brush, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotatePenTransform(ref GpPen pen, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotateTextureTransform(ref GpTexture brush, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipRotateWorldTransform(ref GpGraphics graphics, float angle, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSaveAdd(ref GpImage image, in EncoderParameters encoderParams);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSaveAddImage(ref GpImage image, ref GpImage newImage, in EncoderParameters encoderParams);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSaveGraphics(ref GpGraphics graphics, ref uint state);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSaveImageToFile(ref GpImage image, PWSTR filename, in Guid clsidEncoder, in EncoderParameters encoderParams);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSaveImageToStream(ref GpImage image, IStream stream, in Guid clsidEncoder, in EncoderParameters encoderParams);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScaleLineTransform(ref GpLineGradient brush, float sx, float sy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScaleMatrix(ref Matrix matrix, float scaleX, float scaleY, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScalePathGradientTransform(ref GpPathGradient brush, float sx, float sy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScalePenTransform(ref GpPen pen, float sx, float sy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScaleTextureTransform(ref GpTexture brush, float sx, float sy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipScaleWorldTransform(ref GpGraphics graphics, float sx, float sy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetAdjustableArrowCapFillState(ref GpAdjustableArrowCap cap, [MarshalAs(UnmanagedType.U4)] bool fillState);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetAdjustableArrowCapHeight(ref GpAdjustableArrowCap cap, float height);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetAdjustableArrowCapMiddleInset(ref GpAdjustableArrowCap cap, float middleInset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetAdjustableArrowCapWidth(ref GpAdjustableArrowCap cap, float width);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipGraphics(ref GpGraphics graphics, ref GpGraphics srcgraphics, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipHrgn(ref GpGraphics graphics, HRGN hRgn, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipPath(ref GpGraphics graphics, ref GpPath path, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipRect(ref GpGraphics graphics, float x, float y, float width, float height, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipRectI(ref GpGraphics graphics, int x, int y, int width, int height, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetClipRegion(ref GpGraphics graphics, ref GpRegion region, CombineMode combineMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCompositingMode(ref GpGraphics graphics, CompositingMode compositingMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCompositingQuality(ref GpGraphics graphics, CompositingQuality compositingQuality);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCustomLineCapBaseCap(ref GpCustomLineCap customCap, LineCap baseCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCustomLineCapBaseInset(ref GpCustomLineCap customCap, float inset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCustomLineCapStrokeCaps(ref GpCustomLineCap customCap, LineCap startCap, LineCap endCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCustomLineCapStrokeJoin(ref GpCustomLineCap customCap, LineJoin lineJoin);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetCustomLineCapWidthScale(ref GpCustomLineCap customCap, float widthScale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetEffectParameters(ref CGpEffect effect, nint @params, uint size);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetEmpty(ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesCachedBackground(ref GpImageAttributes imageattr, [MarshalAs(UnmanagedType.U4)] bool enableFlag);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesColorKeys(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, uint colorLow, uint colorHigh);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesColorMatrix(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, in ColorMatrix colorMatrix, in ColorMatrix grayMatrix, ColorMatrixFlags flags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesGamma(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, float gamma);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesNoOp(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesOutputChannel(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, ColorChannelFlags channelFlags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesOutputChannelColorProfile(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, PWSTR colorProfileFilename);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesRemapTable(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, uint mapSize, in ColorMap map);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesThreshold(ref GpImageAttributes imageattr, ColorAdjustType type, [MarshalAs(UnmanagedType.U4)] bool enableFlag, float threshold);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesToIdentity(ref GpImageAttributes imageattr, ColorAdjustType type);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImageAttributesWrapMode(ref GpImageAttributes imageAttr, WrapMode wrap, uint argb, [MarshalAs(UnmanagedType.U4)] bool clamp);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetImagePalette(ref GpImage image, in ColorPalette palette);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetInfinite(ref GpRegion region);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetInterpolationMode(ref GpGraphics graphics, InterpolationMode interpolationMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineBlend(ref GpLineGradient brush, in float blend, in float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineColors(ref GpLineGradient brush, uint color1, uint color2);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineGammaCorrection(ref GpLineGradient brush, [MarshalAs(UnmanagedType.U4)] bool useGammaCorrection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineLinearBlend(ref GpLineGradient brush, float focus, float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLinePresetBlend(ref GpLineGradient brush, in uint blend, in float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineSigmaBlend(ref GpLineGradient brush, float focus, float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineTransform(ref GpLineGradient brush, in Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetLineWrapMode(ref GpLineGradient brush, WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetMatrixElements(ref Matrix matrix, float m11, float m12, float m21, float m22, float dx, float dy);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetMetafileDownLevelRasterizationLimit(ref GpMetafile metafile, uint metafileRasterizationLimitDpi);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPageScale(ref GpGraphics graphics, float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPageUnit(ref GpGraphics graphics, Unit unit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathFillMode(ref GpPath path, FillMode fillmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientBlend(ref GpPathGradient brush, in float blend, in float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientCenterColor(ref GpPathGradient brush, uint colors);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientCenterPoint(ref GpPathGradient brush, in PointF points);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientCenterPointI(ref GpPathGradient brush, in GdiPlusPoint points);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientFocusScales(ref GpPathGradient brush, float xScale, float yScale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientGammaCorrection(ref GpPathGradient brush, [MarshalAs(UnmanagedType.U4)] bool useGammaCorrection);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientLinearBlend(ref GpPathGradient brush, float focus, float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientPath(ref GpPathGradient brush, in GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientPresetBlend(ref GpPathGradient brush, in uint blend, in float positions, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientSigmaBlend(ref GpPathGradient brush, float focus, float scale);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientSurroundColorsWithCount(ref GpPathGradient brush, in uint color, ref int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientTransform(ref GpPathGradient brush, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathGradientWrapMode(ref GpPathGradient brush, WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPathMarker(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenBrushFill(ref GpPen pen, ref GpBrush brush);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenColor(ref GpPen pen, uint argb);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenCompoundArray(ref GpPen pen, in float dash, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenCustomEndCap(ref GpPen pen, ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenCustomStartCap(ref GpPen pen, ref GpCustomLineCap customCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenDashArray(ref GpPen pen, in float dash, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenDashCap197819(ref GpPen pen, DashCap dashCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenDashOffset(ref GpPen pen, float offset);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenDashStyle(ref GpPen pen, DashStyle dashstyle);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenEndCap(ref GpPen pen, LineCap endCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenLineCap197819(ref GpPen pen, LineCap startCap, LineCap endCap, DashCap dashCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenLineJoin(ref GpPen pen, LineJoin lineJoin);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenMiterLimit(ref GpPen pen, float miterLimit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenMode(ref GpPen pen, PenAlignment penMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenStartCap(ref GpPen pen, LineCap startCap);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenTransform(ref GpPen pen, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenUnit(ref GpPen pen, Unit unit);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPenWidth(ref GpPen pen, float width);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPixelOffsetMode(ref GpGraphics graphics, PixelOffsetMode pixelOffsetMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetPropertyItem(ref GpImage image, in PropertyItem item);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetRenderingOrigin(ref GpGraphics graphics, int x, int y);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetSmoothingMode(ref GpGraphics graphics, SmoothingMode smoothingMode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetSolidFillColor(ref GpSolidFill brush, uint color);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatAlign(ref GpStringFormat format, StringAlignment align);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatDigitSubstitution(ref GpStringFormat format, ushort language, StringDigitSubstitute substitute);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatFlags(ref GpStringFormat format, int flags);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatHotkeyPrefix(ref GpStringFormat format, int hotkeyPrefix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatLineAlign(ref GpStringFormat format, StringAlignment align);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatMeasurableCharacterRanges(ref GpStringFormat format, int rangeCount, in CharacterRange ranges);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatTabStops(ref GpStringFormat format, float firstTabOffset, int count, in float tabStops);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetStringFormatTrimming(ref GpStringFormat format, StringTrimming trimming);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetTextContrast(ref GpGraphics graphics, uint contrast);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetTextRenderingHint(ref GpGraphics graphics, TextRenderingHint mode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetTextureTransform(ref GpTexture brush, in Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetTextureWrapMode(ref GpTexture brush, WrapMode wrapmode);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipSetWorldTransform(ref GpGraphics graphics, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipShearMatrix(ref Matrix matrix, float shearX, float shearY, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipStartPathFigure(ref GpPath path);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipStringFormatGetGenericDefault(ref GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipStringFormatGetGenericTypographic(ref GpStringFormat format);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTestControl(GpTestControlEnum control, nint param1);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformMatrixPoints(ref Matrix matrix, ref PointF pts, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformMatrixPointsI(ref Matrix matrix, ref GdiPlusPoint pts, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformPath(ref GpPath path, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformPoints(ref GpGraphics graphics, CoordinateSpace destSpace, CoordinateSpace srcSpace, ref PointF points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformPointsI(ref GpGraphics graphics, CoordinateSpace destSpace, CoordinateSpace srcSpace, ref GdiPlusPoint points, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTransformRegion(ref GpRegion region, ref Matrix matrix);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateClip(ref GpGraphics graphics, float dx, float dy);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateClipI(ref GpGraphics graphics, int dx, int dy);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateLineTransform(ref GpLineGradient brush, float dx, float dy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateMatrix(ref Matrix matrix, float offsetX, float offsetY, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslatePathGradientTransform(ref GpPathGradient brush, float dx, float dy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslatePenTransform(ref GpPen pen, float dx, float dy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateRegion(ref GpRegion region, float dx, float dy);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateRegionI(ref GpRegion region, int dx, int dy);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateTextureTransform(ref GpTexture brush, float dx, float dy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipTranslateWorldTransform(ref GpGraphics graphics, float dx, float dy, MatrixOrder order);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipVectorTransformMatrixPoints(ref Matrix matrix, ref PointF pts, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipVectorTransformMatrixPointsI(ref Matrix matrix, ref GdiPlusPoint pts, int count);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipWarpPath(ref GpPath path, ref Matrix matrix, in PointF points, int count, float srcx, float srcy, float srcwidth, float srcheight, WarpMode warpMode, float flatness);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipWidenPath(ref GpPath nativePath, ref GpPen pen, ref Matrix matrix, float flatness);
    
    [LibraryImport("gdiplus")]
    [PreserveSig]
    public static partial Status GdipWindingModeOutline(ref GpPath path, ref Matrix matrix, float flatness);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getenhmetafilepixelformat
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetEnhMetaFilePixelFormat(HENHMETAFILE hemf, uint cbBuffer, nint/* nint */ ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getpixelformat
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetPixelFormat(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glaccum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glAccum(uint op, float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glalphafunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glAlphaFunc(uint func, float @ref);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glaretexturesresident
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glAreTexturesResident(int n, in uint textures, nint /* byte array */ residences);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glarrayelement
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glArrayElement(int i);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbegin
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBegin(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbindtexture
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBindTexture(uint target, uint texture);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbitmap
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, nint /* byte array */ bitmap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glblendfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBlendFunc(uint sfactor, uint dfactor);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcalllist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCallList(uint list);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcalllists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCallLists(int n, uint type, nint lists);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclear
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClear(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearaccum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearAccum(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearcolor
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearColor(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcleardepth
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearDepth(double depth);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearindex
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearIndex(float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearstencil
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearStencil(int s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclipplane
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClipPlane(uint plane, in double equation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3b(sbyte red, sbyte green, sbyte blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3d(double red, double green, double blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3f(float red, float green, float blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3i(int red, int green, int blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3s(short red, short green, short blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ub
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ub(byte red, byte green, byte blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ubv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ubv(nint /* byte array */ v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ui
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ui(uint red, uint green, uint blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3uiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3uiv(in uint v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3us
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3us(ushort red, ushort green, ushort blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3usv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3usv(in ushort v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4d(double red, double green, double blue, double alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4f(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4i(int red, int green, int blue, int alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4s(short red, short green, short blue, short alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ub
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ub(byte red, byte green, byte blue, byte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ubv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ubv(nint /* byte array */ v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ui
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ui(uint red, uint green, uint blue, uint alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4uiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4uiv(in uint v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4us
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4usv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4usv(in ushort v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolormask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorMask(byte red, byte green, byte blue, byte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolormaterial
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorMaterial(uint face, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolorpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopypixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyPixels(int x, int y, int width, int height, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopyteximage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopyteximage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopytexsubimage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopytexsubimage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcullface
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCullFace(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldeletelists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDeleteLists(uint list, int range);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldeletetextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDeleteTextures(int n, in uint textures);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthFunc(uint func);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthMask(byte flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthrange
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthRange(double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldisable
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDisable(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldisableclientstate
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDisableClientState(uint array);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawarrays
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawArrays(uint mode, int first, int count);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawBuffer(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawelements
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawElements(uint mode, int count, uint type, nint indices);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawpixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawPixels(int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflag
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlag(byte flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflagpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlagPointer(int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflagv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlagv(nint /* byte array */ flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glenable
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnable(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glenableclientstate
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnableClientState(uint array);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glend
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnd();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glendlist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEndList();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1d(double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1dv(in double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1f(float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1fv(in float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2d(double u, double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2dv(in double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2f(float u, float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2fv(in float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalmesh1
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalMesh1(uint mode, int i1, int i2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalmesh2
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalpoint1
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalPoint1(int i);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalpoint2
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalPoint2(int i, int j);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfeedbackbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFeedbackBuffer(int size, uint type, ref float buffer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfinish
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFinish();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glflush
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFlush();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogfv(uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogi(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogiv(uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfrontface
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFrontFace(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfrustum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgenlists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial uint glGenLists(int range);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgentextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGenTextures(int n, ref uint textures);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetbooleanv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetBooleanv(uint pname, nint /* byte array */ @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetclipplane
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetClipPlane(uint plane, ref double equation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetdoublev
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetDoublev(uint pname, ref double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgeterror
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial uint glGetError();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetfloatv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetFloatv(uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetintegerv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetIntegerv(uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetlightfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetLightfv(uint light, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetlightiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetLightiv(uint light, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapdv(uint target, uint query, ref double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapfv(uint target, uint query, ref float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapiv(uint target, uint query, ref int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmaterialfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMaterialfv(uint face, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmaterialiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMaterialiv(uint face, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapfv(uint map, ref float values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapuiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapuiv(uint map, ref uint values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapusv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapusv(uint map, ref ushort values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpointerv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPointerv(uint pname, out nint @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpolygonstipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPolygonStipple(nint /* byte array */ mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetstring
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glGetString(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexenvfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexEnvfv(uint target, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexenviv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexEnviv(uint target, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgendv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGendv(uint coord, uint pname, ref double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgenfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGenfv(uint coord, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgeniv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGeniv(uint coord, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetteximage
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexImage(uint target, int level, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexlevelparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexLevelParameterfv(uint target, int level, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexlevelparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexLevelParameteriv(uint target, int level, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexParameterfv(uint target, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexParameteriv(uint target, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glhint
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glHint(uint target, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexd(double c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexdv(in double c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexf(float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexfv(in float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexi(int c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexiv(in int c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexMask(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexPointer(uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexs
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexs(short c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexsv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexsv(in short c);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexub(byte c);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexubv(nint /* byte array */ c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glinitnames
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glInitNames();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glinterleavedarrays
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glInterleavedArrays(uint format, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glisenabled
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsEnabled(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glislist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsList(uint list);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glistexture
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsTexture(uint texture);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightf(uint light, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightfv(uint light, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllighti
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLighti(uint light, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightiv(uint light, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodelf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModelf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodelfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModelfv(uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodeli
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModeli(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodeliv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModeliv(uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllinestipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLineStipple(int factor, ushort pattern);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllinewidth
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLineWidth(float width);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllistbase
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glListBase(uint @base);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadidentity
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadIdentity();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadmatrixd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadMatrixd(in double m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadmatrixf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadMatrixf(in float m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadName(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllogicop
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLogicOp(uint opcode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap1d(uint target, double u1, double u2, int stride, int order, in double points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap1f(uint target, float u1, float u2, int stride, int order, in float points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, in double points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, in float points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid1d(int un, double u1, double u2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid1f(int un, float u1, float u2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialf(uint face, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialfv(uint face, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmateriali
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMateriali(uint face, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialiv(uint face, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmatrixmode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMatrixMode(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmultmatrixd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMultMatrixd(in double m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmultmatrixf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMultMatrixf(in float m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnewlist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNewList(uint list, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3d(double nx, double ny, double nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3f(float nx, float ny, float nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3i(int nx, int ny, int nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3s(short nx, short ny, short nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormalpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormalPointer(uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glortho
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpassthrough
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPassThrough(float token);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapfv(uint map, int mapsize, in float values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapuiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapuiv(uint map, int mapsize, in uint values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapusv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapusv(uint map, int mapsize, in ushort values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelstoref
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelStoref(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelstorei
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelStorei(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixeltransferf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelTransferf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixeltransferi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelTransferi(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelzoom
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelZoom(float xfactor, float yfactor);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpointsize
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPointSize(float size);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonmode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonMode(uint face, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonoffset
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonOffset(float factor, float units);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonstipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonStipple(nint /* byte array */ mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopAttrib();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopclientattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopClientAttrib();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopmatrix
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopMatrix();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopName();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glprioritizetextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPrioritizeTextures(int n, in uint textures, in float priorities);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushAttrib(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushclientattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushClientAttrib(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushmatrix
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushMatrix();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushName(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2d(double x, double y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2f(float x, float y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2i(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2s(short x, short y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3d(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3f(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3i(int x, int y, int z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3s(short x, short y, short z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4d(double x, double y, double z, double w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4f(float x, float y, float z, float w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4i(int x, int y, int z, int w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4s(short x, short y, short z, short w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glreadbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glReadBuffer(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glreadpixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glReadPixels(int x, int y, int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectd(double x1, double y1, double x2, double y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectdv(in double v1, in double v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectf(float x1, float y1, float x2, float y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectfv(in float v1, in float v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrecti
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRecti(int x1, int y1, int x2, int y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectiv(in int v1, in int v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrects
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRects(short x1, short y1, short x2, short y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectsv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectsv(in short v1, in short v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrendermode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial int glRenderMode(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrotated
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRotated(double angle, double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrotatef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRotatef(float angle, float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscaled
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScaled(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscalef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScalef(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscissor
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScissor(int x, int y, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glselectbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glSelectBuffer(int size, ref uint buffer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glshademodel
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glShadeModel(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilFunc(uint func, int @ref, uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilMask(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilop
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilOp(uint fail, uint zfail, uint zpass);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1d(double s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1f(float s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1i(int s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1s(short s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2d(double s, double t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2dv(in double v);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2f(float s, float t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2i(int s, int t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2s(short s, short t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3d(double s, double t, double r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3dv(in double v);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3f(float s, float t, float r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3i(int s, int t, int r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3s(short s, short t, short r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4d(double s, double t, double r, double q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4f(float s, float t, float r, float q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4i(int s, int t, int r, int q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4s(short s, short t, short r, short q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoordpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoordPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvf(uint target, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvfv(uint target, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvi(uint target, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenviv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnviv(uint target, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgend
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGend(uint coord, uint pname, double param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgendv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGendv(uint coord, uint pname, in double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgenf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGenf(uint coord, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgenfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGenfv(uint coord, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgeni
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGeni(uint coord, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgeniv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGeniv(uint coord, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glteximage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glteximage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameterf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameterf(uint target, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameterfv(uint target, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameteri
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameteri(uint target, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameteriv(uint target, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexsubimage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexsubimage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltranslated
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTranslated(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltranslatef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTranslatef(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubegincurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginCurve(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubeginpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubeginsurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginSurface(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubegintrim
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginTrim(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubuild1dmipmaps
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluBuild1DMipmaps(uint target, int components, int width, uint format, uint type, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubuild2dmipmaps
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluBuild2DMipmaps(uint target, int components, int width, int height, uint format, uint type, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glucylinder
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluCylinder(ref GLUquadric qobj, double baseRadius, double topRadius, double height, int slices, int stacks);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletenurbsrenderer
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteNurbsRenderer(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletequadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteQuadric(ref GLUquadric state);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletetess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteTess(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludisk
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDisk(ref GLUquadric qobj, double innerRadius, double outerRadius, int slices, int loops);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendcurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndCurve(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendsurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndSurface(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendtrim
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndTrim(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluerrorstring
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial byte gluErrorString(uint errCode);
    
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial PWSTR gluErrorUnicodeStringEXT(uint errCode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugetnurbsproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluGetNurbsProperty(ref GLUnurbs nobj, uint property, ref float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugetstring
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial byte gluGetString(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugettessproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluGetTessProperty(ref GLUtesselator tess, uint which, ref double value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluloadsamplingmatrices
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluLoadSamplingMatrices(ref GLUnurbs nobj, in float modelMatrix, in float projMatrix, in int viewport);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glulookat
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluLookAt(double eyex, double eyey, double eyez, double centerx, double centery, double centerz, double upx, double upy, double upz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewnurbsrenderer
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial GLUnurbs gluNewNurbsRenderer();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewquadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial GLUquadric gluNewQuadric();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewtess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial GLUtesselator gluNewTess();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunextcontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNextContour(ref GLUtesselator tess, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbs
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsCallback(ref GLUnurbs nobj, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbscurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsCurve(ref GLUnurbs nobj, int nknots, ref float knot, int stride, ref float ctlarray, int order, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbsproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsProperty(ref GLUnurbs nobj, uint property, float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbssurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsSurface(ref GLUnurbs nobj, int sknot_count, ref float sknot, int tknot_count, ref float tknot, int s_stride, int t_stride, ref float ctlarray, int sorder, int torder, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluortho2d
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluOrtho2D(double left, double right, double bottom, double top);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupartialdisk
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPartialDisk(ref GLUquadric qobj, double innerRadius, double outerRadius, int slices, int loops, double startAngle, double sweepAngle);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluperspective
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPerspective(double fovy, double aspect, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupickmatrix
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPickMatrix(double x, double y, double width, double height, ref int viewport);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluproject
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluProject(double objx, double objy, double objz, in double modelMatrix, in double projMatrix, in int viewport, ref double winx, ref double winy, ref double winz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupwlcurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPwlCurve(ref GLUnurbs nobj, int count, ref float array, int stride, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricCallback(ref GLUquadric qobj, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricdrawstyle
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricDrawStyle(ref GLUquadric quadObject, uint drawStyle);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricnormals
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricNormals(ref GLUquadric quadObject, uint normals);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricorientation
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricOrientation(ref GLUquadric quadObject, uint orientation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadrictexture
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricTexture(ref GLUquadric quadObject, byte textureCoords);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluscaleimage
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluScaleImage(uint format, int widthin, int heightin, uint typein, nint datain, int widthout, int heightout, uint typeout, nint dataout);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glusphere
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluSphere(ref GLUquadric qobj, double radius, int slices, int stacks);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessbegincontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessBeginContour(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessbeginpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessBeginPolygon(ref GLUtesselator tess, nint polygon_data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessCallback(ref GLUtesselator tess, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessendcontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessEndContour(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessendpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessEndPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessnormal
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessNormal(ref GLUtesselator tess, double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessProperty(ref GLUtesselator tess, uint which, double value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessvertex
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessVertex(ref GLUtesselator tess, ref double coords, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluunproject
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluUnProject(double winx, double winy, double winz, in double modelMatrix, in double projMatrix, in int viewport, ref double objx, ref double objy, ref double objz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2d(double x, double y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2f(float x, float y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2i(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2s(short x, short y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3d(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3f(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3i(int x, int y, int z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3s(short x, short y, short z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4d(double x, double y, double z, double w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4f(float x, float y, float z, float w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4i(int x, int y, int z, int w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4s(short x, short y, short z, short w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertexpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertexPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glviewport
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glViewport(int x, int y, int width, int height);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateAllocator(HANDLE ConnectionHandle, in KSALLOCATOR_FRAMING AllocatorFraming, out HANDLE AllocatorHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateAllocator2(HANDLE ConnectionHandle, in KSALLOCATOR_FRAMING AllocatorFraming, out HANDLE AllocatorHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateClock(HANDLE ConnectionHandle, in KSCLOCK_CREATE ClockCreate, out HANDLE ClockHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateClock2(HANDLE ConnectionHandle, in KSCLOCK_CREATE ClockCreate, out HANDLE ClockHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreatePin(HANDLE FilterHandle, in KSPIN_CONNECT Connect, uint DesiredAccess, out HANDLE ConnectionHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreatePin2(HANDLE FilterHandle, in KSPIN_CONNECT Connect, uint DesiredAccess, out HANDLE ConnectionHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateTopologyNode(HANDLE ParentHandle, in KSNODE_CREATE NodeCreate, uint DesiredAccess, out HANDLE NodeHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateTopologyNode2(HANDLE ParentHandle, in KSNODE_CREATE NodeCreate, uint DesiredAccess, out HANDLE NodeHandle);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMediaType(int Position, out AM_MEDIA_TYPE AmMediaType, HANDLE FilterHandle, uint PinFactoryId);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMediaTypeCount(HANDLE FilterHandle, uint PinFactoryId, out uint MediaTypeCount);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMultiplePinFactoryItems(HANDLE FilterHandle, uint PinFactoryId, uint PropertyId, out nint Items);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsOpenDefaultDevice(in Guid Category, uint Access, out HANDLE DeviceHandle);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsResolveRequiredAttributes(in KSDATAFORMAT DataRange, nint/* nint */ Attributes);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsSynchronousDeviceControl(HANDLE Handle, uint IoControl, nint/* nint */ InBuffer, uint InLength, nint/* nint */ OutBuffer, uint OutLength, nint/* nint */ BytesReturned);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setpixelformat
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool SetPixelFormat(HDC hdc, int format, in PIXELFORMATDESCRIPTOR ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-swapbuffers
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool SwapBuffers(HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcopycontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglCopyContext(HGLRC param0, HGLRC param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcreatecontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HGLRC wglCreateContext(HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcreatelayercontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HGLRC wglCreateLayerContext(HDC param0, int param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wgldeletecontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglDeleteContext(HGLRC param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wgldescribelayerplane
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglDescribeLayerPlane(HDC param0, int param1, int param2, uint param3, ref LAYERPLANEDESCRIPTOR param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetcurrentcontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HGLRC wglGetCurrentContext();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetcurrentdc
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HDC wglGetCurrentDC();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetlayerpaletteentries
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int wglGetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, ref COLORREF param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetprocaddress
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial PROC wglGetProcAddress(PSTR param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglmakecurrent
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglMakeCurrent(HDC param0, HGLRC param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglrealizelayerpalette
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglRealizeLayerPalette(HDC param0, int param1, [MarshalAs(UnmanagedType.U4)] bool param2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglsetlayerpaletteentries
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int wglSetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, in COLORREF param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglsharelists
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglShareLists(HGLRC param0, HGLRC param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglswaplayerbuffers
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglSwapLayerBuffers(HDC param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontbitmapsa
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglUseFontBitmapsA(HDC param0, uint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontbitmapsw
    [LibraryImport("OPENGL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglUseFontBitmapsW(HDC param0, uint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontoutlinesa
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglUseFontOutlinesA(HDC param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontoutlinesw
    [LibraryImport("OPENGL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool wglUseFontOutlinesW(HDC param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicconvertbitmapsource
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICConvertBitmapSource(in Guid dstFormat, IWICBitmapSource pISrc, out IWICBitmapSource ppIDst);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wiccreatebitmapfromsection
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICCreateBitmapFromSection(uint width, uint height, in Guid pixelFormat, HANDLE hSection, uint stride, uint offset, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wiccreatebitmapfromsectionex
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT WICCreateBitmapFromSectionEx(uint width, uint height, in Guid pixelFormat, HANDLE hSection, uint stride, uint offset, WICSectionAccessLevel desiredAccessLevel, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicgetmetadatacontentsize
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICGetMetadataContentSize(in Guid guidContainerFormat, IWICMetadataWriter pIWriter, out ulong pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapguidtoshortname
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapGuidToShortName(in Guid guid, uint cchName, ref PWSTR wzName, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapschematoname
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapSchemaToName(in Guid guidMetadataFormat, PWSTR pwzSchema, uint cchName, ref PWSTR wzName, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapshortnametoguid
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapShortNameToGuid(PWSTR wzName, out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicmatchmetadatacontent
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMatchMetadataContent(in Guid guidContainerFormat, nint/* nint */ pguidVendor, IStream pIStream, out Guid pguidMetadataFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicserializemetadatacontent
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICSerializeMetadataContent(in Guid guidContainerFormat, IWICMetadataWriter pIWriter, uint dwPersistOptions, IStream pIStream);
}
