#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-named_profile_info
[StructLayout(LayoutKind.Sequential)]
public partial struct NAMED_PROFILE_INFO
{
    public uint dwFlags;
    public uint dwCount;
    public uint dwCountDevCoordinates;
    public InlineArraySByte_32 szPrefix;
    public InlineArraySByte_32 szSuffix;
}
