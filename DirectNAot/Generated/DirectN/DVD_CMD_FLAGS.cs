namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-dvd_cmd_flags
public enum DVD_CMD_FLAGS
{
    DVD_CMD_FLAG_None = 0,
    DVD_CMD_FLAG_Flush = 1,
    DVD_CMD_FLAG_SendEvents = 2,
    DVD_CMD_FLAG_Block = 4,
    DVD_CMD_FLAG_StartWhenRendered = 8,
    DVD_CMD_FLAG_EndAfterRendered = 16,
}
