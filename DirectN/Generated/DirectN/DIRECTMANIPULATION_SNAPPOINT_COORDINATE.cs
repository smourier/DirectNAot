﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_snappoint_coordinate
[Flags]
public enum DIRECTMANIPULATION_SNAPPOINT_COORDINATE
{
    DIRECTMANIPULATION_COORDINATE_BOUNDARY = 0,
    DIRECTMANIPULATION_COORDINATE_ORIGIN = 1,
    DIRECTMANIPULATION_COORDINATE_MIRRORED = 16,
}
