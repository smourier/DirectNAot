#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_WMDRM_KEYINFOLIST
{
    public int lResult;
    public uint ulKeyuuidBufferLen;
    public InlineArrayGuid_1 argKeyuuidBuffer; // variable-length array placeholder
}
