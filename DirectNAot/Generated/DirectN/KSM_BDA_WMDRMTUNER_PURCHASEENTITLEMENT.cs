#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_WMDRMTUNER_PURCHASEENTITLEMENT
{
    public KSM_NODE NodeMethod;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR12 cLanguage;
    public uint ulPurchaseTokenLength;
    public InlineArrayByte1 argbDataBuffer; // variable-length array placeholder
}
