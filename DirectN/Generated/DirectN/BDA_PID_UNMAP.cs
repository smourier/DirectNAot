#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_PID_UNMAP
{
    public uint ulcPIDs;
    public InlineArrayUInt32_1 aulPIDs; // variable-length array placeholder
}
