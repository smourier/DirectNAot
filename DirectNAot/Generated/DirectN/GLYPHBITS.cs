﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-glyphbits
[StructLayout(LayoutKind.Sequential)]
public partial struct GLYPHBITS
{
    public POINTL ptlOrigin;
    public SIZE sizlBitmap;
    public InlineArrayByte_1 aj; // variable-length array placeholder
}
