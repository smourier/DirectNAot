#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_WMDRM_RENEWLICENSE
{
    public int lResult;
    public uint ulDescrambleStatus;
    public uint ulXmrLicenseOutputLength;
    public InlineArrayByte1 argbXmrLicenceOutputBuffer; // variable-length array placeholder
}
