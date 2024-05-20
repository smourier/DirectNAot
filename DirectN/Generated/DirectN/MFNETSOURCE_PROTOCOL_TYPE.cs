#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfnetsource_protocol_type
public enum MFNETSOURCE_PROTOCOL_TYPE
{
    MFNETSOURCE_UNDEFINED = 0,
    MFNETSOURCE_HTTP = 1,
    MFNETSOURCE_RTSP = 2,
    MFNETSOURCE_FILE = 3,
    MFNETSOURCE_MULTICAST = 4,
}
