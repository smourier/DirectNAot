#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WNF_KSCAMERA_STREAMSTATE_INFO
{
    public uint ProcessId;
    public uint SessionId;
    public uint StreamState;
    public uint Reserved;
}
