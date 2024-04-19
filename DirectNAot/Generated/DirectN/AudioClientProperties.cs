namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ns-audioclient-audioclientproperties~r1
[StructLayout(LayoutKind.Sequential)]
public partial struct AudioClientProperties
{
    public uint cbSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bIsOffload;
    public AUDIO_STREAM_CATEGORY eCategory;
    public AUDCLNT_STREAMOPTIONS Options;
}
