#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/ne-mfcaptureengine-mf_capture_engine_sink_type
public enum MF_CAPTURE_ENGINE_SINK_TYPE
{
    MF_CAPTURE_ENGINE_SINK_TYPE_RECORD = 0,
    MF_CAPTURE_ENGINE_SINK_TYPE_PREVIEW = 1,
    MF_CAPTURE_ENGINE_SINK_TYPE_PHOTO = 2,
}
