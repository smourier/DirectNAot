#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSE_NODE
{
    public KSIDENTIFIER Event;
    public uint NodeId;
    public uint Reserved;
}
