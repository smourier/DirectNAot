namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8d536ca1-0cca-4956-a837-786963755584")]
public partial interface ID3D11ShaderReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out D3D11_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getconstantbufferbyindex
    [PreserveSig]
    public ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getconstantbufferbyname
    [PreserveSig]
    public ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getresourcebindingdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, out D3D11_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getinputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInputParameterDesc(uint ParameterIndex, out D3D11_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getoutputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOutputParameterDesc(uint ParameterIndex, out D3D11_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getpatchconstantparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPatchConstantParameterDesc(uint ParameterIndex, out D3D11_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getvariablebyname
    [PreserveSig]
    public ID3D11ShaderReflectionVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getresourcebindingdescbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResourceBindingDescByName(PSTR Name, out D3D11_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getmovinstructioncount
    [PreserveSig]
    public uint GetMovInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getmovcinstructioncount
    [PreserveSig]
    public uint GetMovcInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getconversioninstructioncount
    [PreserveSig]
    public uint GetConversionInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getbitwiseinstructioncount
    [PreserveSig]
    public uint GetBitwiseInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getgsinputprimitive
    [PreserveSig]
    public D3D_PRIMITIVE GetGSInputPrimitive();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-issamplefrequencyshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsSampleFrequencyShader();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getnuminterfaceslots
    [PreserveSig]
    public uint GetNumInterfaceSlots();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getminfeaturelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMinFeatureLevel(out D3D_FEATURE_LEVEL pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getthreadgroupsize
    [PreserveSig]
    public uint GetThreadGroupSize(nint/* nint */ pSizeX, nint/* nint */ pSizeY, nint/* nint */ pSizeZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getrequiresflags
    [PreserveSig]
    public ulong GetRequiresFlags();
}
