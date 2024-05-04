#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ns-d2d1_3-d2d1_gradient_mesh_patch
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_GRADIENT_MESH_PATCH
{
    public D2D_POINT_2F point00;
    public D2D_POINT_2F point01;
    public D2D_POINT_2F point02;
    public D2D_POINT_2F point03;
    public D2D_POINT_2F point10;
    public D2D_POINT_2F point11;
    public D2D_POINT_2F point12;
    public D2D_POINT_2F point13;
    public D2D_POINT_2F point20;
    public D2D_POINT_2F point21;
    public D2D_POINT_2F point22;
    public D2D_POINT_2F point23;
    public D2D_POINT_2F point30;
    public D2D_POINT_2F point31;
    public D2D_POINT_2F point32;
    public D2D_POINT_2F point33;
    public D2D1_COLOR_F color00;
    public D2D1_COLOR_F color03;
    public D2D1_COLOR_F color30;
    public D2D1_COLOR_F color33;
    public D2D1_PATCH_EDGE_MODE topEdgeMode;
    public D2D1_PATCH_EDGE_MODE leftEdgeMode;
    public D2D1_PATCH_EDGE_MODE bottomEdgeMode;
    public D2D1_PATCH_EDGE_MODE rightEdgeMode;
}
