﻿#nullable enable
namespace DirectN;

[Flags]
public enum GENERIC_ACCESS_RIGHTS : uint
{
    GENERIC_READ = 2147483648,
    GENERIC_WRITE = 1073741824,
    GENERIC_EXECUTE = 536870912,
    GENERIC_ALL = 268435456,
}
