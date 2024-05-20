#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfstreamsink_marker_type
public enum MFSTREAMSINK_MARKER_TYPE
{
    MFSTREAMSINK_MARKER_DEFAULT = 0,
    MFSTREAMSINK_MARKER_ENDOFSEGMENT = 1,
    MFSTREAMSINK_MARKER_TICK = 2,
    MFSTREAMSINK_MARKER_EVENT = 3,
}
