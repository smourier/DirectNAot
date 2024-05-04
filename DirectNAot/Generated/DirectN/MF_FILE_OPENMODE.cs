#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf_file_openmode
public enum MF_FILE_OPENMODE
{
    MF_OPENMODE_FAIL_IF_NOT_EXIST = 0,
    MF_OPENMODE_FAIL_IF_EXIST = 1,
    MF_OPENMODE_RESET_IF_EXIST = 2,
    MF_OPENMODE_APPEND_IF_EXIST = 3,
    MF_OPENMODE_DELETE_IF_EXIST = 4,
}
