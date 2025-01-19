﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_enumfilter
public enum PROPDESC_ENUMFILTER
{
    PDEF_ALL = 0,
    PDEF_SYSTEM = 1,
    PDEF_NONSYSTEM = 2,
    PDEF_VIEWABLE = 3,
    PDEF_QUERYABLE = 4,
    PDEF_INFULLTEXTQUERY = 5,
    PDEF_COLUMN = 6,
}
