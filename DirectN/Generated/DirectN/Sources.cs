﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-sources
public partial struct Sources
{
    public uint sourceId;
    public int numTargets;
    public InlineArrayUInt32_1 aTargets; // variable-length array placeholder
}
