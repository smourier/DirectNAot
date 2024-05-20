#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_filter_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_FILTER_PARAMETERS
{
    public XAUDIO2_FILTER_TYPE Type;
    public float Frequency;
    public float OneOverQ;
}
