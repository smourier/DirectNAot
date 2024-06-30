﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-compcolor
public partial struct COMPCOLOR
{
    public COLORREF crText;
    public COLORREF crBackground;
    public uint dwEffects;
}
