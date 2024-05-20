#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nn-d3d10_1shader-id3d10shaderreflection1
[GeneratedComInterface, Guid("c3457783-a846-47ce-9520-cea6f66e7447")]
public partial interface ID3D10ShaderReflection1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D10_SHADER_DESC pDesc);
    
    [PreserveSig]
    ID3D10ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
    
    [PreserveSig]
    ID3D10ShaderReflectionConstantBuffer GetConstantBufferByName(PSTR Name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDesc(uint ResourceIndex, out D3D10_SHADER_INPUT_BIND_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputParameterDesc(uint ParameterIndex, out D3D10_SIGNATURE_PARAMETER_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputParameterDesc(uint ParameterIndex, out D3D10_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getvariablebyname
    [PreserveSig]
    ID3D10ShaderReflectionVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getresourcebindingdescbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDescByName(PSTR Name, out D3D10_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getmovinstructioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMovInstructionCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getmovcinstructioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMovcInstructionCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getconversioninstructioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConversionInstructionCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getbitwiseinstructioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBitwiseInstructionCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-getgsinputprimitive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGSInputPrimitive(out D3D_PRIMITIVE pPrim);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-islevel9shader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLevel9Shader([MarshalAs(UnmanagedType.U4)] out bool pbLevel9Shader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1shader/nf-d3d10_1shader-id3d10shaderreflection1-issamplefrequencyshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSampleFrequencyShader([MarshalAs(UnmanagedType.U4)] out bool pbSampleFrequency);
}
