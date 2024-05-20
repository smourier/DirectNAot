#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ne-d3d11shadertracing-d3d11_trace_gs_input_primitive
public enum D3D11_TRACE_GS_INPUT_PRIMITIVE
{
    D3D11_TRACE_GS_INPUT_PRIMITIVE_UNDEFINED = 0,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_POINT = 1,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE = 2,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE = 3,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE_ADJ = 6,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE_ADJ = 7,
}
