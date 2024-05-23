#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectshadervariable
[GeneratedComInterface, Guid("80849279-c799-4797-8c33-0407a07d9e06")]
public partial interface ID3D10EffectShaderVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getshaderdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShaderDesc(uint ShaderIndex, out D3D10_EFFECT_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexShader(uint ShaderIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10VertexShader>))] out ID3D10VertexShader ppVS);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getgeometryshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeometryShader(uint ShaderIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10GeometryShader>))] out ID3D10GeometryShader ppGS);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelShader(uint ShaderIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10PixelShader>))] out ID3D10PixelShader ppPS);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getinputsignatureelementdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputSignatureElementDesc(uint ShaderIndex, uint Element, out D3D10_SIGNATURE_PARAMETER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getoutputsignatureelementdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputSignatureElementDesc(uint ShaderIndex, uint Element, out D3D10_SIGNATURE_PARAMETER_DESC pDesc);
}
