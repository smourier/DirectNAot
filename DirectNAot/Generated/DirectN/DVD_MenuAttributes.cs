namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_menuattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_MenuAttributes
{
    public InlineArrayBOOL8 fCompatibleRegion;
    public DVD_VideoAttributes VideoAttributes;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fAudioPresent;
    public DVD_AudioAttributes AudioAttributes;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSubpicturePresent;
    public DVD_SubpictureAttributes SubpictureAttributes;
}
