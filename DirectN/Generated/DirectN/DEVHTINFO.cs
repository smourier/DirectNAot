﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-devhtinfo
public partial struct DEVHTINFO
{
    public uint HTFlags;
    public uint HTPatternSize;
    public uint DevPelsDPI;
    public COLORINFO ColorInfo;
}
