namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/ne-xpsdigitalsignature-xps_sign_flags
[Flags]
public enum XPS_SIGN_FLAGS
{
    XPS_SIGN_FLAGS_NONE = 0,
    XPS_SIGN_FLAGS_IGNORE_MARKUP_COMPATIBILITY = 1,
}
