#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/ne-d3d11sdklayers-d3d11_message_severity
public enum D3D11_MESSAGE_SEVERITY
{
    D3D11_MESSAGE_SEVERITY_CORRUPTION = 0,
    D3D11_MESSAGE_SEVERITY_ERROR = 1,
    D3D11_MESSAGE_SEVERITY_WARNING = 2,
    D3D11_MESSAGE_SEVERITY_INFO = 3,
    D3D11_MESSAGE_SEVERITY_MESSAGE = 4,
}
