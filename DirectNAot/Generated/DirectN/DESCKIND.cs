﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-desckind
public enum DESCKIND
{
    DESCKIND_NONE = 0,
    DESCKIND_FUNCDESC = 1,
    DESCKIND_VARDESC = 2,
    DESCKIND_TYPECOMP = 3,
    DESCKIND_IMPLICITAPPOBJ = 4,
    DESCKIND_MAX = 5,
}
