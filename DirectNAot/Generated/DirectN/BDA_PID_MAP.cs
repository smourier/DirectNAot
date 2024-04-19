namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_PID_MAP
{
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
    public uint ulcPIDs;
    public InlineArrayUInt321 aulPIDs; // variable-length array placeholder
}
