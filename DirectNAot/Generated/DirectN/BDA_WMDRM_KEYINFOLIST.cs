namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_WMDRM_KEYINFOLIST
{
    public int lResult;
    public uint ulKeyuuidBufferLen;
    public InlineArrayGuid1 argKeyuuidBuffer; // variable-length array placeholder
}
