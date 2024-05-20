#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPDISPLAYTOKEN
{
    public PWSTR pszLexical;
    public PWSTR pszDisplay;
    public byte bDisplayAttributes;
}
