#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_NODE
{
    public KSIDENTIFIER Method;
    public uint NodeId;
    public uint Reserved;
}
