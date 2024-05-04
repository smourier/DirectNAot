#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/ne-segment-dvdspext
public enum DVDSPExt
{
    dvdSPExt_NotSpecified = 0,
    dvdSPExt_Caption_Normal = 1,
    dvdSPExt_Caption_Big = 2,
    dvdSPExt_Caption_Children = 3,
    dvdSPExt_CC_Normal = 5,
    dvdSPExt_CC_Big = 6,
    dvdSPExt_CC_Children = 7,
    dvdSPExt_Forced = 9,
    dvdSPExt_DirectorComments_Normal = 13,
    dvdSPExt_DirectorComments_Big = 14,
    dvdSPExt_DirectorComments_Children = 15,
}
