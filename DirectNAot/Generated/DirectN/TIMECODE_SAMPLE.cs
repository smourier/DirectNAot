namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-timecode_sample
[StructLayout(LayoutKind.Sequential)]
public partial struct TIMECODE_SAMPLE
{
    public long qwTick;
    public TIMECODE timecode;
    public uint dwUser;
    public TIMECODE_SAMPLE_FLAGS dwFlags;
}
