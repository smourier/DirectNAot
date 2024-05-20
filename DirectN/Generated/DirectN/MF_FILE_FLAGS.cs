#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf_file_flags
public enum MF_FILE_FLAGS
{
    MF_FILEFLAGS_NONE = 0,
    MF_FILEFLAGS_NOBUFFERING = 1,
    MF_FILEFLAGS_ALLOW_WRITE_SHARING = 2,
}
