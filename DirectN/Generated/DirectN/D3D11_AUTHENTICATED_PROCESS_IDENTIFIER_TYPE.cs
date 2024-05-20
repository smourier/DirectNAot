#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_authenticated_process_identifier_type
public enum D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE
{
    D3D11_PROCESSIDTYPE_UNKNOWN = 0,
    D3D11_PROCESSIDTYPE_DWM = 1,
    D3D11_PROCESSIDTYPE_HANDLE = 2,
}
