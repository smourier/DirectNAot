﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_horizontalalignment
[Flags]
public enum DIRECTMANIPULATION_HORIZONTALALIGNMENT
{
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_NONE = 0,
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_LEFT = 1,
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_CENTER = 2,
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_RIGHT = 4,
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_UNLOCKCENTER = 8,
}
