﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_PALETTE_DATA
{
    public ushort NumEntries;
    public ushort FirstEntry;
    public InlineArrayUInt16_1 Colors; // variable-length array placeholder
}
