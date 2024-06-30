#nullable enable
namespace DirectN;

public partial struct KSCAMERA_PROFILE_CONCURRENCYINFO
{
    public Guid ReferenceGuid;
    public uint Reserved;
    public uint ProfileCount;
    public nint Profiles;
}
