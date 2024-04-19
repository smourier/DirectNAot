namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRULEENTRY
{
    public SPRULEHANDLE hRule;
    public SPSTATEHANDLE hInitialState;
    public uint Attributes;
    public nint pvClientRuleContext;
    public nint pvClientGrammarContext;
}
