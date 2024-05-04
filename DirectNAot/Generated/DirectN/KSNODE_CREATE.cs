#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSNODE_CREATE
{
    public uint CreateFlags;
    public uint Node;
}
