#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_CAS_CAPTURETOKEN
{
    public KSM_NODE NodeMethod;
    public uint ulTokenLength;
    public InlineArrayByte1 argbToken; // variable-length array placeholder
}
