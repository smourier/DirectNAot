#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypesbase/ns-wtypesbase-coauthinfo
public partial struct COAUTHINFO
{
    public uint dwAuthnSvc;
    public uint dwAuthzSvc;
    public PWSTR pwszServerPrincName;
    public uint dwAuthnLevel;
    public uint dwImpersonationLevel;
    public nint pAuthIdentityData;
    public uint dwCapabilities;
}
