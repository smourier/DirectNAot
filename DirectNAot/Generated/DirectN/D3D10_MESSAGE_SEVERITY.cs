#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/ne-d3d10sdklayers-d3d10_message_severity
public enum D3D10_MESSAGE_SEVERITY
{
    D3D10_MESSAGE_SEVERITY_CORRUPTION = 0,
    D3D10_MESSAGE_SEVERITY_ERROR = 1,
    D3D10_MESSAGE_SEVERITY_WARNING = 2,
    D3D10_MESSAGE_SEVERITY_INFO = 3,
    D3D10_MESSAGE_SEVERITY_MESSAGE = 4,
}
