namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_NETWORKCAMERACONTROL_EVENT_INFO
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public InlineArraySystemChar1 EventFilter; // variable-length array placeholder
}
