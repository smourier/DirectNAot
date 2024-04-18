﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_font_feature
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_FONT_FEATURE
{
    public DWRITE_FONT_FEATURE_TAG nameTag;
    public uint parameter;
}
