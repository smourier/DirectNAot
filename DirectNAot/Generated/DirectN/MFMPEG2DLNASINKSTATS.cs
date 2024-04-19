namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmp2dlna/ns-mfmp2dlna-mfmpeg2dlnasinkstats
[StructLayout(LayoutKind.Sequential)]
public partial struct MFMPEG2DLNASINKSTATS
{
    public ulong cBytesWritten;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fPAL;
    public uint fccVideo;
    public uint dwVideoWidth;
    public uint dwVideoHeight;
    public ulong cVideoFramesReceived;
    public ulong cVideoFramesEncoded;
    public ulong cVideoFramesSkipped;
    public ulong cBlackVideoFramesEncoded;
    public ulong cVideoFramesDuplicated;
    public uint cAudioSamplesPerSec;
    public uint cAudioChannels;
    public ulong cAudioBytesReceived;
    public ulong cAudioFramesEncoded;
}
