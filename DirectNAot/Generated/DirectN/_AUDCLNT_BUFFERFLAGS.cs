#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ne-audioclient-_audclnt_bufferflags
public enum _AUDCLNT_BUFFERFLAGS
{
    AUDCLNT_BUFFERFLAGS_DATA_DISCONTINUITY = 1,
    AUDCLNT_BUFFERFLAGS_SILENT = 2,
    AUDCLNT_BUFFERFLAGS_TIMESTAMP_ERROR = 4,
}
