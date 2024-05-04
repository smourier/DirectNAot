#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOMODULE_PROPERTY
{
    public KSIDENTIFIER Property;
    public Guid ClassId;
    public uint InstanceId;
}
