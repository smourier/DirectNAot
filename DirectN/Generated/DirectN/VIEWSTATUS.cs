#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ne-ocidl-viewstatus
public enum VIEWSTATUS
{
    VIEWSTATUS_OPAQUE = 1,
    VIEWSTATUS_SOLIDBKGND = 2,
    VIEWSTATUS_DVASPECTOPAQUE = 4,
    VIEWSTATUS_DVASPECTTRANSPARENT = 8,
    VIEWSTATUS_SURFACE = 16,
    VIEWSTATUS_3DSURFACE = 32,
}
