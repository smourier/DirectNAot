#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PIDListSpanningEvent
{
    public ushort wPIDCount;
    public InlineArrayUInt321 pulPIDs; // variable-length array placeholder
}
