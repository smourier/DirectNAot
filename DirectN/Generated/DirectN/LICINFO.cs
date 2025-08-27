#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-licinfo
public partial struct LICINFO
{
    public int cbLicInfo;
    public BOOL fRuntimeKeyAvail;
    public BOOL fLicVerified;
}
