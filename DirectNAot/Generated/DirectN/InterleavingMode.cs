namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-interleavingmode
public enum InterleavingMode
{
    INTERLEAVE_NONE = 0,
    INTERLEAVE_CAPTURE = 1,
    INTERLEAVE_FULL = 2,
    INTERLEAVE_NONE_BUFFERED = 3,
}
