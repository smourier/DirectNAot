﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avistdindex_entry
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVISTDINDEX_ENTRY
{
    public uint dwOffset;
    public uint dwSize;
}
