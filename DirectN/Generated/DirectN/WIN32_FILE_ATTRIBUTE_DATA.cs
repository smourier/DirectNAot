#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/fileapi/ns-fileapi-win32_file_attribute_data
public partial struct WIN32_FILE_ATTRIBUTE_DATA
{
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;
    public uint nFileSizeHigh;
    public uint nFileSizeLow;
}
