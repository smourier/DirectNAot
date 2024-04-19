namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTELEPHONY_PROVIDERCHANGE
{
    public TELEPHONY_CALLTYPE CallType;
    public TELEPHONY_PROVIDERCHANGEOP ProviderChangeOp;
}
