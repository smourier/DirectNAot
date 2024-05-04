#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSNODEPROPERTY
{
    public KSIDENTIFIER Property;
    public uint NodeId;
    public uint Reserved;
}
