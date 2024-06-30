﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-drawpatrect
public partial struct DRAWPATRECT
{
    public POINT ptPosition;
    public POINT ptSize;
    public ushort wStyle;
    public ushort wPattern;
}
