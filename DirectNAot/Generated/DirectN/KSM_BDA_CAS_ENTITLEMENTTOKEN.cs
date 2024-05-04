#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_CAS_ENTITLEMENTTOKEN
{
    public KSM_NODE NodeMethod;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR12 cLanguage;
    public uint ulRequestType;
    public uint ulEntitlementTokenLen;
    public InlineArrayByte1 argbEntitlementToken; // variable-length array placeholder
}
