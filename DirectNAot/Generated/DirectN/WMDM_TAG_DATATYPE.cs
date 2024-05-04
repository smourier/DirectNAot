#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-tag-datatype
public enum WMDM_TAG_DATATYPE
{
    WMDM_TYPE_DWORD = 0,
    WMDM_TYPE_STRING = 1,
    WMDM_TYPE_BINARY = 2,
    WMDM_TYPE_BOOL = 3,
    WMDM_TYPE_QWORD = 4,
    WMDM_TYPE_WORD = 5,
    WMDM_TYPE_GUID = 6,
    WMDM_TYPE_DATE = 7,
}
