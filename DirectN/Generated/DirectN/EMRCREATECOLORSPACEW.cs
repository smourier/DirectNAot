﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatecolorspacew
public partial struct EMRCREATECOLORSPACEW
{
    public EMR emr;
    public uint ihCS;
    public LOGCOLORSPACEW lcs;
    public uint dwFlags;
    public uint cbData;
    public InlineArrayByte_1 Data; // variable-length array placeholder
}
