﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/structuredquerycondition/ne-structuredquerycondition-condition_operation
public enum CONDITION_OPERATION
{
    COP_IMPLICIT = 0,
    COP_EQUAL = 1,
    COP_NOTEQUAL = 2,
    COP_LESSTHAN = 3,
    COP_GREATERTHAN = 4,
    COP_LESSTHANOREQUAL = 5,
    COP_GREATERTHANOREQUAL = 6,
    COP_VALUE_STARTSWITH = 7,
    COP_VALUE_ENDSWITH = 8,
    COP_VALUE_CONTAINS = 9,
    COP_VALUE_NOTCONTAINS = 10,
    COP_DOSWILDCARDS = 11,
    COP_WORD_EQUAL = 12,
    COP_WORD_STARTSWITH = 13,
    COP_APPLICATION_SPECIFIC = 14,
}
