﻿#nullable enable
namespace DirectN;

public partial struct SPRULEENTRY
{
    public SPRULEHANDLE hRule;
    public SPSTATEHANDLE hInitialState;
    public uint Attributes;
    public nint pvClientRuleContext;
    public nint pvClientGrammarContext;
}
