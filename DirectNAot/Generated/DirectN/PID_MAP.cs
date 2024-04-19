namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/pid-map
[StructLayout(LayoutKind.Sequential)]
public partial struct PID_MAP
{
    public uint ulPID;
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
}
