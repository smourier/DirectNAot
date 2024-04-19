namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_url_trust_status
public enum MF_URL_TRUST_STATUS
{
    MF_LICENSE_URL_UNTRUSTED = 0,
    MF_LICENSE_URL_TRUSTED = 1,
    MF_LICENSE_URL_TAMPERED = 2,
}
