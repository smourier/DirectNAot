#nullable enable
namespace DirectN;

public partial struct KSAUDIOMODULE_DESCRIPTOR
{
    public Guid ClassId;
    public uint InstanceId;
    public uint VersionMajor;
    public uint VersionMinor;
    public InlineArraySystemChar_128 Name;
}
