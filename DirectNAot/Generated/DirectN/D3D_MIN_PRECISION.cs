namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_min_precision
public enum D3D_MIN_PRECISION
{
    D3D_MIN_PRECISION_DEFAULT = 0,
    D3D_MIN_PRECISION_FLOAT_16 = 1,
    D3D_MIN_PRECISION_FLOAT_2_8 = 2,
    D3D_MIN_PRECISION_RESERVED = 3,
    D3D_MIN_PRECISION_SINT_16 = 4,
    D3D_MIN_PRECISION_UINT_16 = 5,
    D3D_MIN_PRECISION_ANY_16 = 240,
    D3D_MIN_PRECISION_ANY_10 = 241,
}
