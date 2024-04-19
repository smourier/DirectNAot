﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ne-wmcodecdsp-wmt_prop_datatype
public enum WMT_PROP_DATATYPE
{
    WMT_PROP_TYPE_DWORD = 0,
    WMT_PROP_TYPE_STRING = 1,
    WMT_PROP_TYPE_BINARY = 2,
    WMT_PROP_TYPE_BOOL = 3,
    WMT_PROP_TYPE_QWORD = 4,
    WMT_PROP_TYPE_WORD = 5,
    WMT_PROP_TYPE_GUID = 6,
}
