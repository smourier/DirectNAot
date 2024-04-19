namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TIMECODE_S
{
    public KSIDENTIFIER Property;
    public TIMECODE_SAMPLE TimecodeSamp;
}
