namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf_attribute_type
public enum MF_ATTRIBUTE_TYPE
{
    MF_ATTRIBUTE_UINT32 = 19,
    MF_ATTRIBUTE_UINT64 = 21,
    MF_ATTRIBUTE_DOUBLE = 5,
    MF_ATTRIBUTE_GUID = 72,
    MF_ATTRIBUTE_STRING = 31,
    MF_ATTRIBUTE_BLOB = 4113,
    MF_ATTRIBUTE_IUNKNOWN = 13,
}
