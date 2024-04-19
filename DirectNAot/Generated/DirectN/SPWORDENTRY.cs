namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDENTRY
{
    public SPWORDHANDLE hWord;
    public ushort LangID;
    public PWSTR pszDisplayText;
    public PWSTR pszLexicalForm;
    public nint aPhoneId;
    public nint pvClientContext;
}
