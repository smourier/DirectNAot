#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_BUFFER
{
    public KSM_NODE NodeMethod;
    public uint ulBufferSize;
    public InlineArrayByte1 argbBuffer; // variable-length array placeholder
}
