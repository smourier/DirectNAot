#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ne-dvdmedia-am_dvdcopystate
public enum AM_DVDCOPYSTATE
{
    AM_DVDCOPYSTATE_INITIALIZE = 0,
    AM_DVDCOPYSTATE_INITIALIZE_TITLE = 1,
    AM_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED = 2,
    AM_DVDCOPYSTATE_AUTHENTICATION_REQUIRED = 3,
    AM_DVDCOPYSTATE_DONE = 4,
}
