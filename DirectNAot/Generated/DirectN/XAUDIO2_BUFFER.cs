namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_buffer
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_BUFFER
{
    public uint Flags;
    public uint AudioBytes;
    public nint pAudioData;
    public uint PlayBegin;
    public uint PlayLength;
    public uint LoopBegin;
    public uint LoopLength;
    public uint LoopCount;
    public nint pContext;
}
