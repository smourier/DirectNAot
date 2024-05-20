#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_PID_MAP
{
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
    public uint ulcPIDs;
    public InlineArrayUInt32_1 aulPIDs; // variable-length array placeholder
}
