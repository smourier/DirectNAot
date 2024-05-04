#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mf_transcode_sink_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MF_TRANSCODE_SINK_INFO
{
    public uint dwVideoStreamID;
    public nint pVideoMediaType;
    public uint dwAudioStreamID;
    public nint pAudioMediaType;
}
