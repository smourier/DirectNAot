﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-typekind
public enum TYPEKIND
{
    TKIND_ENUM = 0,
    TKIND_RECORD = 1,
    TKIND_MODULE = 2,
    TKIND_INTERFACE = 3,
    TKIND_DISPATCH = 4,
    TKIND_COCLASS = 5,
    TKIND_ALIAS = 6,
    TKIND_UNION = 7,
    TKIND_MAX = 8,
}
