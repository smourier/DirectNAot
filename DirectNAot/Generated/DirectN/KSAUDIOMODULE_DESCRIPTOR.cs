namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOMODULE_DESCRIPTOR
{
    public Guid ClassId;
    public uint InstanceId;
    public uint VersionMajor;
    public uint VersionMinor;
    public InlineArraySystemChar128 Name;
}
