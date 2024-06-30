#nullable enable
namespace DirectN;

public partial struct KSM_BDA_CAS_ENTITLEMENTTOKEN
{
    public KSM_NODE NodeMethod;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR_12 cLanguage;
    public uint ulRequestType;
    public uint ulEntitlementTokenLen;
    public InlineArrayByte_1 argbEntitlementToken; // variable-length array placeholder
}
