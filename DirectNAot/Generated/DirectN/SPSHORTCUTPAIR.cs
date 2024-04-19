namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSHORTCUTPAIR
{
    public nint pNextSHORTCUTPAIR;
    public ushort LangID;
    public SPSHORTCUTTYPE shType;
    public PWSTR pszDisplay;
    public PWSTR pszSpoken;
}
