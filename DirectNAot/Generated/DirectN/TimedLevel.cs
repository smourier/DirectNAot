namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/effects/ns-effects-timedlevel
[StructLayout(LayoutKind.Sequential)]
public partial struct TimedLevel
{
    public InlineArrayByte2048 frequency;
    public InlineArrayByte2048 waveform;
    public int state;
    public long timeStamp;
}
