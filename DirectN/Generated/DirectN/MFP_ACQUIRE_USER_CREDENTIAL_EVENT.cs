#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_acquire_user_credential_event
[StructLayout(LayoutKind.Sequential)]
public partial struct MFP_ACQUIRE_USER_CREDENTIAL_EVENT
{
    public MFP_EVENT_HEADER header;
    public nuint dwUserData;
    public BOOL fProceedWithAuthentication;
    public HRESULT hrAuthenticationStatus;
    public PWSTR pwszURL;
    public PWSTR pwszSite;
    public PWSTR pwszRealm;
    public PWSTR pwszPackage;
    public int nRetries;
    public uint flags;
    public nint pCredential;
}
