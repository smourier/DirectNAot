﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-orientation_preference
[Flags]
public enum ORIENTATION_PREFERENCE
{
    ORIENTATION_PREFERENCE_NONE = 0,
    ORIENTATION_PREFERENCE_LANDSCAPE = 1,
    ORIENTATION_PREFERENCE_PORTRAIT = 2,
    ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 4,
    ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 8,
}
