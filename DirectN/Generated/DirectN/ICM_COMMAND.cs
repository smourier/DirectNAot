﻿#nullable enable
namespace DirectN;

public enum ICM_COMMAND : uint
{
    ICM_ADDPROFILE = 1,
    ICM_DELETEPROFILE = 2,
    ICM_QUERYPROFILE = 3,
    ICM_SETDEFAULTPROFILE = 4,
    ICM_REGISTERICMATCHER = 5,
    ICM_UNREGISTERICMATCHER = 6,
    ICM_QUERYMATCH = 7,
}
