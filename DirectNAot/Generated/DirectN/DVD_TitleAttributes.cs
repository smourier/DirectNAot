namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_titleattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_TitleAttributes
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DVD_TITLE_APPMODE AppMode;
        
        [FieldOffset(0)]
        public DVD_HMSF_TIMECODE TitleLength;
    }
    
    public _Anonymous_e__Union Anonymous;
    public DVD_VideoAttributes VideoAttributes;
    public uint ulNumberOfAudioStreams;
    public InlineArrayDVD_AudioAttributes8 AudioAttributes;
    public InlineArrayDVD_MultichannelAudioAttributes8 MultichannelAudioAttributes;
    public uint ulNumberOfSubpictureStreams;
    public InlineArrayDVD_SubpictureAttributes32 SubpictureAttributes;
}
