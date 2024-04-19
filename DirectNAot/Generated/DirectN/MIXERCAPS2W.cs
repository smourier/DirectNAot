namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCAPS2W
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar32 szPname;
    public uint fdwSupport;
    public uint cDestinations;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
