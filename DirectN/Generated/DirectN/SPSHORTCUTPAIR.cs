#nullable enable
namespace DirectN;

public partial struct SPSHORTCUTPAIR
{
    public nint pNextSHORTCUTPAIR;
    public ushort LangID;
    public SPSHORTCUTTYPE shType;
    public PWSTR pszDisplay;
    public PWSTR pszSpoken;
}
