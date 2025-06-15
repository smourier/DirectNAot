﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/ne-objidlbase-apttypequalifier
public enum APTTYPEQUALIFIER
{
    APTTYPEQUALIFIER_NONE = 0,
    APTTYPEQUALIFIER_IMPLICIT_MTA = 1,
    APTTYPEQUALIFIER_NA_ON_MTA = 2,
    APTTYPEQUALIFIER_NA_ON_STA = 3,
    APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 4,
    APTTYPEQUALIFIER_NA_ON_MAINSTA = 5,
    APTTYPEQUALIFIER_APPLICATION_STA = 6,
    APTTYPEQUALIFIER_RESERVED_1 = 7,
}
