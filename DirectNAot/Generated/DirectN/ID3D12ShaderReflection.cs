namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflection
[GeneratedComInterface, Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e")]
public partial interface ID3D12ShaderReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out D3D12_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconstantbufferbyindex
    [PreserveSig]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconstantbufferbyname
    [PreserveSig]
    public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getresourcebindingdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getinputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInputParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getoutputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOutputParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getpatchconstantparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPatchConstantParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getvariablebyname
    [PreserveSig]
    public ID3D12ShaderReflectionVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getresourcebindingdescbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResourceBindingDescByName(PSTR Name, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getmovinstructioncount
    [PreserveSig]
    public uint GetMovInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getmovcinstructioncount
    [PreserveSig]
    public uint GetMovcInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconversioninstructioncount
    [PreserveSig]
    public uint GetConversionInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getbitwiseinstructioncount
    [PreserveSig]
    public uint GetBitwiseInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getgsinputprimitive
    [PreserveSig]
    public D3D_PRIMITIVE GetGSInputPrimitive();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-issamplefrequencyshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsSampleFrequencyShader();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getnuminterfaceslots
    [PreserveSig]
    public uint GetNumInterfaceSlots();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getminfeaturelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMinFeatureLevel(out D3D_FEATURE_LEVEL pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getthreadgroupsize
    [PreserveSig]
    public uint GetThreadGroupSize(nint/* nint */ pSizeX, nint/* nint */ pSizeY, nint/* nint */ pSizeZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getrequiresflags
    [PreserveSig]
    public ulong GetRequiresFlags();
}
