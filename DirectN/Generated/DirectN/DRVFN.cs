﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-drvfn
public partial struct DRVFN
{
    public uint iFunc;
    public nint pfn;
}
