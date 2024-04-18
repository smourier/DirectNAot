namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ne-objidl-stream_seek
public enum STREAM_SEEK : uint
{
    STREAM_SEEK_SET = 0,
    STREAM_SEEK_CUR = 1,
    STREAM_SEEK_END = 2,
}
