#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_PHOTOCONFIRMATION
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public uint PhotoConfirmationIndex;
    public uint Reserved;
}
