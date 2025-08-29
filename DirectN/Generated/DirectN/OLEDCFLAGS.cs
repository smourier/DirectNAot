#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ne-ocidl-oledcflags
public enum OLEDCFLAGS
{
    OLEDC_NODRAW = 1,
    OLEDC_PAINTBKGND = 2,
    OLEDC_OFFSCREEN = 4,
}
