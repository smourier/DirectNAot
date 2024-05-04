#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/ne-spatialaudioclient-spatial_audio_stream_options
[Flags]
public enum SPATIAL_AUDIO_STREAM_OPTIONS
{
    SPATIAL_AUDIO_STREAM_OPTIONS_NONE = 0,
    SPATIAL_AUDIO_STREAM_OPTIONS_OFFLOAD = 1,
}
