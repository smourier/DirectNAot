#nullable enable
namespace DirectN;

public partial struct BDA_WMDRM_RENEWLICENSE
{
    public int lResult;
    public uint ulDescrambleStatus;
    public uint ulXmrLicenseOutputLength;
    public InlineArrayByte_1 argbXmrLicenceOutputBuffer; // variable-length array placeholder
}
