#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_SERIAL
{
    public KSIDENTIFIER PropTypeSet;
    public uint Id;
    public uint PropertyLength;
}
