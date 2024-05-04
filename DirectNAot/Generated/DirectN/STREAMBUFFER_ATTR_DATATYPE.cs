#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/ne-sbe-streambuffer_attr_datatype
public enum STREAMBUFFER_ATTR_DATATYPE
{
    STREAMBUFFER_TYPE_DWORD = 0,
    STREAMBUFFER_TYPE_STRING = 1,
    STREAMBUFFER_TYPE_BINARY = 2,
    STREAMBUFFER_TYPE_BOOL = 3,
    STREAMBUFFER_TYPE_QWORD = 4,
    STREAMBUFFER_TYPE_WORD = 5,
    STREAMBUFFER_TYPE_GUID = 6,
}
