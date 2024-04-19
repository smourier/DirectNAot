namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmplibrarytype
public enum WMPLibraryType
{
    wmpltUnknown = 0,
    wmpltAll = 1,
    wmpltLocal = 2,
    wmpltRemote = 3,
    wmpltDisc = 4,
    wmpltPortableDevice = 5,
}
