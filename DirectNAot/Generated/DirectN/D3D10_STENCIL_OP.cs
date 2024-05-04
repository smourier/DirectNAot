#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_stencil_op
public enum D3D10_STENCIL_OP
{
    D3D10_STENCIL_OP_KEEP = 1,
    D3D10_STENCIL_OP_ZERO = 2,
    D3D10_STENCIL_OP_REPLACE = 3,
    D3D10_STENCIL_OP_INCR_SAT = 4,
    D3D10_STENCIL_OP_DECR_SAT = 5,
    D3D10_STENCIL_OP_INVERT = 6,
    D3D10_STENCIL_OP_INCR = 7,
    D3D10_STENCIL_OP_DECR = 8,
}
