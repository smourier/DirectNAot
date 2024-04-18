﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/Stg/stgm-constants
public enum STGM : uint
{
    STGM_DIRECT = 0,
    STGM_TRANSACTED = 65536,
    STGM_SIMPLE = 134217728,
    STGM_READ = 0,
    STGM_WRITE = 1,
    STGM_READWRITE = 2,
    STGM_SHARE_DENY_NONE = 64,
    STGM_SHARE_DENY_READ = 48,
    STGM_SHARE_DENY_WRITE = 32,
    STGM_SHARE_EXCLUSIVE = 16,
    STGM_PRIORITY = 262144,
    STGM_DELETEONRELEASE = 67108864,
    STGM_NOSCRATCH = 1048576,
    STGM_CREATE = 4096,
    STGM_CONVERT = 131072,
    STGM_FAILIFTHERE = 0,
    STGM_NOSNAPSHOT = 2097152,
    STGM_DIRECT_SWMR = 4194304,
}
