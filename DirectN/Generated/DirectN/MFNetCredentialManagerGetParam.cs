#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfnetcredentialmanagergetparam
public partial struct MFNetCredentialManagerGetParam
{
    public HRESULT hrOp;
    public BOOL fAllowLoggedOnUser;
    public BOOL fClearTextPackage;
    public PWSTR pszUrl;
    public PWSTR pszSite;
    public PWSTR pszRealm;
    public PWSTR pszPackage;
    public int nRetries;
}
