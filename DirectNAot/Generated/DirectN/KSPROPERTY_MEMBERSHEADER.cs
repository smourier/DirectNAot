namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_MEMBERSHEADER
{
    public uint MembersFlags;
    public uint MembersSize;
    public uint MembersCount;
    public uint Flags;
}
