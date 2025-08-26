#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-libflags
public enum LIBFLAGS
{
    LIBFLAG_FRESTRICTED = 1,
    LIBFLAG_FCONTROL = 2,
    LIBFLAG_FHIDDEN = 4,
    LIBFLAG_FHASDISKIMAGE = 8,
}
