#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mf_topostatus
public enum MF_TOPOSTATUS
{
    MF_TOPOSTATUS_INVALID = 0,
    MF_TOPOSTATUS_READY = 100,
    MF_TOPOSTATUS_STARTED_SOURCE = 200,
    MF_TOPOSTATUS_DYNAMIC_CHANGED = 210,
    MF_TOPOSTATUS_SINK_SWITCHED = 300,
    MF_TOPOSTATUS_ENDED = 400,
}
