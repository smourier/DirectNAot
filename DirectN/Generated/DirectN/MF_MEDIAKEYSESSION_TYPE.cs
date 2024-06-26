﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_mediakeysession_type
public enum MF_MEDIAKEYSESSION_TYPE
{
    MF_MEDIAKEYSESSION_TYPE_TEMPORARY = 0,
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_LICENSE = 1,
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_RELEASE_MESSAGE = 2,
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_USAGE_RECORD = 3,
}
