﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_trace_value
public partial struct D3D11_TRACE_VALUE
{
    public InlineArrayUInt32_4 Bits;
    public byte ValidMask;
}
