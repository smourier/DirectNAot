namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_filesink_mode
public enum WMT_FILESINK_MODE
{
    WMT_FM_SINGLE_BUFFERS = 1,
    WMT_FM_FILESINK_DATA_UNITS = 2,
    WMT_FM_FILESINK_UNBUFFERED = 4,
}
