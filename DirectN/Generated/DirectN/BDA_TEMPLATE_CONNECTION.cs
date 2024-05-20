#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TEMPLATE_CONNECTION
{
    public uint FromNodeType;
    public uint FromNodePinType;
    public uint ToNodeType;
    public uint ToNodePinType;
}
