#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/ne-mfreadwrite-mf_source_reader_control_flag
[Flags]
public enum MF_SOURCE_READER_CONTROL_FLAG
{
    MF_SOURCE_READER_CONTROLF_DRAIN = 1,
}
