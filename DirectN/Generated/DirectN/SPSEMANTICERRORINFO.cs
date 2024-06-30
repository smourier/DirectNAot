#nullable enable
namespace DirectN;

public partial struct SPSEMANTICERRORINFO
{
    public uint ulLineNumber;
    public PWSTR pszScriptLine;
    public PWSTR pszSource;
    public PWSTR pszDescription;
    public HRESULT hrResultCode;
}
