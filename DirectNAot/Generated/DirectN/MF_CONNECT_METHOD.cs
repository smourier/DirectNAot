﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_connect_method
public enum MF_CONNECT_METHOD
{
    MF_CONNECT_DIRECT = 0,
    MF_CONNECT_ALLOW_CONVERTER = 1,
    MF_CONNECT_ALLOW_DECODER = 3,
    MF_CONNECT_RESOLVE_INDEPENDENT_OUTPUTTYPES = 4,
    MF_CONNECT_AS_OPTIONAL = 65536,
    MF_CONNECT_AS_OPTIONAL_BRANCH = 131072,
}
