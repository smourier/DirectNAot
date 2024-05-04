#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_FRAMEILLUMINATION
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public uint Flags;
    public uint Reserved;
}
