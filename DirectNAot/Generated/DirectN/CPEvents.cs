namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/ne-encdec-cpevents
public enum CPEvents
{
    CPEVENT_NONE = 0,
    CPEVENT_RATINGS = 1,
    CPEVENT_COPP = 2,
    CPEVENT_LICENSE = 3,
    CPEVENT_ROLLBACK = 4,
    CPEVENT_SAC = 5,
    CPEVENT_DOWNRES = 6,
    CPEVENT_STUBLIB = 7,
    CPEVENT_UNTRUSTEDGRAPH = 8,
    CPEVENT_PROTECTWINDOWED = 9,
}
