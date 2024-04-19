namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-stream_id_map
[StructLayout(LayoutKind.Sequential)]
public partial struct STREAM_ID_MAP
{
    public uint stream_id;
    public uint dwMediaSampleContent;
    public uint ulSubstreamFilterValue;
    public int iDataOffset;
}
