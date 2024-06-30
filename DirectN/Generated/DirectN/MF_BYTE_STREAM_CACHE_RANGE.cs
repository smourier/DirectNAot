#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mf_byte_stream_cache_range
public partial struct MF_BYTE_STREAM_CACHE_RANGE
{
    public ulong qwStartOffset;
    public ulong qwEndOffset;
}
