#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_DIGITALWINDOW
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public KSCAMERA_EXTENDEDPROP_DIGITALWINDOW_SETTING Window;
}
