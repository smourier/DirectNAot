#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflection
[GeneratedComInterface, Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e")]
public partial interface ID3D12ShaderReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D12_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconstantbufferbyindex
    [PreserveSig]
    ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconstantbufferbyname
    [PreserveSig]
    ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getresourcebindingdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDesc(uint ResourceIndex, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getinputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getoutputparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getpatchconstantparameterdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPatchConstantParameterDesc(uint ParameterIndex, out D3D12_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getvariablebyname
    [PreserveSig]
    ID3D12ShaderReflectionVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getresourcebindingdescbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDescByName(PSTR Name, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getmovinstructioncount
    [PreserveSig]
    uint GetMovInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getmovcinstructioncount
    [PreserveSig]
    uint GetMovcInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getconversioninstructioncount
    [PreserveSig]
    uint GetConversionInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getbitwiseinstructioncount
    [PreserveSig]
    uint GetBitwiseInstructionCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getgsinputprimitive
    [PreserveSig]
    D3D_PRIMITIVE GetGSInputPrimitive();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-issamplefrequencyshader
    [PreserveSig]
    BOOL IsSampleFrequencyShader();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getnuminterfaceslots
    [PreserveSig]
    uint GetNumInterfaceSlots();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getminfeaturelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinFeatureLevel(out D3D_FEATURE_LEVEL pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getthreadgroupsize
    [PreserveSig]
    uint GetThreadGroupSize(nint /* optional uint* */ pSizeX, nint /* optional uint* */ pSizeY, nint /* optional uint* */ pSizeZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflection-getrequiresflags
    [PreserveSig]
    ulong GetRequiresFlags();
}
