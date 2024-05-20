#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_WMDRMTUNER_PURCHASEENTITLEMENT
{
    public int lResult;
    public uint ulDescrambleStatus;
    public uint ulCaptureTokenLength;
    public InlineArrayByte_1 argbCaptureTokenBuffer; // variable-length array placeholder
}
