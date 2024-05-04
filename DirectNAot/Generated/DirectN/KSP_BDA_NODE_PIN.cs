#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSP_BDA_NODE_PIN
{
    public KSIDENTIFIER Property;
    public uint ulNodeType;
    public uint ulInputPinId;
    public uint ulOutputPinId;
}
