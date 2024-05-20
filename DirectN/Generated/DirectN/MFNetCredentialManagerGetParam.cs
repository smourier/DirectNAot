#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfnetcredentialmanagergetparam
[StructLayout(LayoutKind.Sequential)]
public partial struct MFNetCredentialManagerGetParam
{
    public HRESULT hrOp;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fAllowLoggedOnUser;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fClearTextPackage;
    public PWSTR pszUrl;
    public PWSTR pszSite;
    public PWSTR pszRealm;
    public PWSTR pszPackage;
    public int nRetries;
}
