﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_interaction_type
public enum DIRECTMANIPULATION_INTERACTION_TYPE
{
    DIRECTMANIPULATION_INTERACTION_BEGIN = 0,
    DIRECTMANIPULATION_INTERACTION_TYPE_MANIPULATION = 1,
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_TAP = 2,
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_HOLD = 3,
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_CROSS_SLIDE = 4,
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_PINCH_ZOOM = 5,
    DIRECTMANIPULATION_INTERACTION_END = 100,
}
