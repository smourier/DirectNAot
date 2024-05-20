#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSP_NODE
{
    public KSIDENTIFIER Property;
    public uint NodeId;
    public uint Reserved;
}
