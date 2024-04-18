﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ne-d3d10effect-d3d10_device_state_types
public enum D3D10_DEVICE_STATE_TYPES
{
    D3D10_DST_SO_BUFFERS = 1,
    D3D10_DST_OM_RENDER_TARGETS = 2,
    D3D10_DST_OM_DEPTH_STENCIL_STATE = 3,
    D3D10_DST_OM_BLEND_STATE = 4,
    D3D10_DST_VS = 5,
    D3D10_DST_VS_SAMPLERS = 6,
    D3D10_DST_VS_SHADER_RESOURCES = 7,
    D3D10_DST_VS_CONSTANT_BUFFERS = 8,
    D3D10_DST_GS = 9,
    D3D10_DST_GS_SAMPLERS = 10,
    D3D10_DST_GS_SHADER_RESOURCES = 11,
    D3D10_DST_GS_CONSTANT_BUFFERS = 12,
    D3D10_DST_PS = 13,
    D3D10_DST_PS_SAMPLERS = 14,
    D3D10_DST_PS_SHADER_RESOURCES = 15,
    D3D10_DST_PS_CONSTANT_BUFFERS = 16,
    D3D10_DST_IA_VERTEX_BUFFERS = 17,
    D3D10_DST_IA_INDEX_BUFFER = 18,
    D3D10_DST_IA_INPUT_LAYOUT = 19,
    D3D10_DST_IA_PRIMITIVE_TOPOLOGY = 20,
    D3D10_DST_RS_VIEWPORTS = 21,
    D3D10_DST_RS_SCISSOR_RECTS = 22,
    D3D10_DST_RS_RASTERIZER_STATE = 23,
    D3D10_DST_PREDICATION = 24,
}
