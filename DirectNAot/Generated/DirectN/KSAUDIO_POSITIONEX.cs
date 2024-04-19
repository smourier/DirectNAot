namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_POSITIONEX
{
    public long TimerFrequency;
    public long TimeStamp1;
    public KSAUDIO_POSITION Position;
    public long TimeStamp2;
}
