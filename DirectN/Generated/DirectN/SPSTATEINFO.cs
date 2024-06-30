#nullable enable
namespace DirectN;

public partial struct SPSTATEINFO
{
    public uint cAllocatedEntries;
    public nint pTransitions;
    public uint cEpsilons;
    public uint cRules;
    public uint cWords;
    public uint cSpecialTransitions;
}
