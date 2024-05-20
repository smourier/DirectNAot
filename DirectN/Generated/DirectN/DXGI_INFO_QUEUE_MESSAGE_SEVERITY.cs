#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/ne-dxgidebug-dxgi_info_queue_message_severity
public enum DXGI_INFO_QUEUE_MESSAGE_SEVERITY
{
    DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION = 0,
    DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR = 1,
    DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING = 2,
    DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO = 3,
    DXGI_INFO_QUEUE_MESSAGE_SEVERITY_MESSAGE = 4,
}
