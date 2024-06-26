﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_motion_types
[Flags]
public enum DIRECTMANIPULATION_MOTION_TYPES
{
    DIRECTMANIPULATION_MOTION_NONE = 0,
    DIRECTMANIPULATION_MOTION_TRANSLATEX = 1,
    DIRECTMANIPULATION_MOTION_TRANSLATEY = 2,
    DIRECTMANIPULATION_MOTION_ZOOM = 4,
    DIRECTMANIPULATION_MOTION_CENTERX = 16,
    DIRECTMANIPULATION_MOTION_CENTERY = 32,
    DIRECTMANIPULATION_MOTION_ALL = 55,
}
