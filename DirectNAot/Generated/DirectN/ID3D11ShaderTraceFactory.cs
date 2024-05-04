#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nn-d3d11shadertracing-id3d11shadertracefactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1fbad429-66ab-41cc-9617-667ac10e4459")]
public partial interface ID3D11ShaderTraceFactory
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertracefactory-createshadertrace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderTrace(nint pShader, in D3D11_SHADER_TRACE_DESC pTraceDesc, out ID3D11ShaderTrace ppShaderTrace);
}
