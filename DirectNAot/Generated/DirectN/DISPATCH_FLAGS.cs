﻿namespace DirectN;

[Flags]
public enum DISPATCH_FLAGS : ushort
{
    DISPATCH_METHOD = 1,
    DISPATCH_PROPERTYGET = 2,
    DISPATCH_PROPERTYPUT = 4,
    DISPATCH_PROPERTYPUTREF = 8,
}
