#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_PROFILE
{
    public Guid ProfileId;
    public uint Index;
    public uint Reserved;
}
