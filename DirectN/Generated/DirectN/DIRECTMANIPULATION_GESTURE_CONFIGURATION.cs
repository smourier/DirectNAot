﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_gesture_configuration
[Flags]
public enum DIRECTMANIPULATION_GESTURE_CONFIGURATION
{
    DIRECTMANIPULATION_GESTURE_NONE = 0,
    DIRECTMANIPULATION_GESTURE_DEFAULT = 0,
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_VERTICAL = 8,
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_HORIZONTAL = 16,
    DIRECTMANIPULATION_GESTURE_PINCH_ZOOM = 32,
}
