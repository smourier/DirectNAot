﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_attr_datatype
public enum WMT_ATTR_DATATYPE
{
    WMT_TYPE_DWORD = 0,
    WMT_TYPE_STRING = 1,
    WMT_TYPE_BINARY = 2,
    WMT_TYPE_BOOL = 3,
    WMT_TYPE_QWORD = 4,
    WMT_TYPE_WORD = 5,
    WMT_TYPE_GUID = 6,
}
