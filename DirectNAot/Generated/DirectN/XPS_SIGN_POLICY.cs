namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/ne-xpsdigitalsignature-xps_sign_policy
[Flags]
public enum XPS_SIGN_POLICY
{
    XPS_SIGN_POLICY_NONE = 0,
    XPS_SIGN_POLICY_CORE_PROPERTIES = 1,
    XPS_SIGN_POLICY_SIGNATURE_RELATIONSHIPS = 2,
    XPS_SIGN_POLICY_PRINT_TICKET = 4,
    XPS_SIGN_POLICY_DISCARD_CONTROL = 8,
    XPS_SIGN_POLICY_ALL = 15,
}
