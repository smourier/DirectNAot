namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRULE
{
    public PWSTR pszRuleName;
    public uint ulRuleId;
    public uint dwAttributes;
}
