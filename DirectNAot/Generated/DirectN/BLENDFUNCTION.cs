﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-blendfunction
[StructLayout(LayoutKind.Sequential)]
public partial struct BLENDFUNCTION
{
    public byte BlendOp;
    public byte BlendFlags;
    public byte SourceConstantAlpha;
    public byte AlphaFormat;
}
