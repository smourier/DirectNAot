namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DxcShaderHash
{
    public uint Flags;
    public InlineArrayByte16 HashDigest;
}
