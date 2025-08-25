#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-proppageinfo
public partial struct PROPPAGEINFO
{
    public uint cb;
    public PWSTR pszTitle;
    public SIZE size;
    public PWSTR pszDocString;
    public PWSTR pszHelpFile;
    public uint dwHelpContext;
}
