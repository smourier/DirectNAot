namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfnetsource_cache_state
public enum MFNETSOURCE_CACHE_STATE
{
    MFNETSOURCE_CACHE_UNAVAILABLE = 0,
    MFNETSOURCE_CACHE_ACTIVE_WRITING = 1,
    MFNETSOURCE_CACHE_ACTIVE_COMPLETE = 2,
}
