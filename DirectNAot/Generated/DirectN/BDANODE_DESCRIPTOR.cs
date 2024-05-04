#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDANODE_DESCRIPTOR
{
    public uint ulBdaNodeType;
    public Guid guidFunction;
    public Guid guidName;
}
