#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioapotypes/ne-audioapotypes-apo_buffer_flags
public enum APO_BUFFER_FLAGS
{
    BUFFER_INVALID = 0,
    BUFFER_VALID = 1,
    BUFFER_SILENT = 2,
}
