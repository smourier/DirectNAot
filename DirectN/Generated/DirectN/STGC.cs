#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypes/ne-wtypes-stgc
[Flags]
public enum STGC
{
    STGC_DEFAULT = 0,
    STGC_OVERWRITE = 1,
    STGC_ONLYIFCURRENT = 2,
    STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
    STGC_CONSOLIDATE = 8,
}
