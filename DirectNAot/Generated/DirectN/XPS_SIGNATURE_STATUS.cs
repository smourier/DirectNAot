namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/ne-xpsdigitalsignature-xps_signature_status
public enum XPS_SIGNATURE_STATUS
{
    XPS_SIGNATURE_STATUS_INCOMPLIANT = 1,
    XPS_SIGNATURE_STATUS_INCOMPLETE = 2,
    XPS_SIGNATURE_STATUS_BROKEN = 3,
    XPS_SIGNATURE_STATUS_QUESTIONABLE = 4,
    XPS_SIGNATURE_STATUS_VALID = 5,
}
