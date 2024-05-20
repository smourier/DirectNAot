#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpplaylistchangeeventtype
public enum WMPPlaylistChangeEventType
{
    wmplcUnknown = 0,
    wmplcClear = 1,
    wmplcInfoChange = 2,
    wmplcMove = 3,
    wmplcDelete = 4,
    wmplcInsert = 5,
    wmplcAppend = 6,
    wmplcPrivate = 7,
    wmplcNameChange = 8,
    wmplcMorph = 9,
    wmplcSort = 10,
    wmplcLast = 11,
}
