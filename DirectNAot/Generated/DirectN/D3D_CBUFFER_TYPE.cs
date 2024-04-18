namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_cbuffer_type
public enum D3D_CBUFFER_TYPE
{
    D3D_CT_CBUFFER = 0,
    D3D_CT_TBUFFER = 1,
    D3D_CT_INTERFACE_POINTERS = 2,
    D3D_CT_RESOURCE_BIND_INFO = 3,
    D3D10_CT_CBUFFER = 0,
    D3D10_CT_TBUFFER = 1,
    D3D11_CT_CBUFFER = 0,
    D3D11_CT_TBUFFER = 1,
    D3D11_CT_INTERFACE_POINTERS = 2,
    D3D11_CT_RESOURCE_BIND_INFO = 3,
}
