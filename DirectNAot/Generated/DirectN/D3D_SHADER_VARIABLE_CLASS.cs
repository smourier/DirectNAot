namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class
public enum D3D_SHADER_VARIABLE_CLASS
{
    D3D_SVC_SCALAR = 0,
    D3D_SVC_VECTOR = 1,
    D3D_SVC_MATRIX_ROWS = 2,
    D3D_SVC_MATRIX_COLUMNS = 3,
    D3D_SVC_OBJECT = 4,
    D3D_SVC_STRUCT = 5,
    D3D_SVC_INTERFACE_CLASS = 6,
    D3D_SVC_INTERFACE_POINTER = 7,
    D3D10_SVC_SCALAR = 0,
    D3D10_SVC_VECTOR = 1,
    D3D10_SVC_MATRIX_ROWS = 2,
    D3D10_SVC_MATRIX_COLUMNS = 3,
    D3D10_SVC_OBJECT = 4,
    D3D10_SVC_STRUCT = 5,
    D3D11_SVC_INTERFACE_CLASS = 6,
    D3D11_SVC_INTERFACE_POINTER = 7,
}
