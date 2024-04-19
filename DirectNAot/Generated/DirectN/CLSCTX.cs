﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypesbase/ne-wtypesbase-clsctx
[Flags]
public enum CLSCTX : uint
{
    CLSCTX_INPROC_SERVER = 1,
    CLSCTX_INPROC_HANDLER = 2,
    CLSCTX_LOCAL_SERVER = 4,
    CLSCTX_INPROC_SERVER16 = 8,
    CLSCTX_REMOTE_SERVER = 16,
    CLSCTX_INPROC_HANDLER16 = 32,
    CLSCTX_RESERVED1 = 64,
    CLSCTX_RESERVED2 = 128,
    CLSCTX_RESERVED3 = 256,
    CLSCTX_RESERVED4 = 512,
    CLSCTX_NO_CODE_DOWNLOAD = 1024,
    CLSCTX_RESERVED5 = 2048,
    CLSCTX_NO_CUSTOM_MARSHAL = 4096,
    CLSCTX_ENABLE_CODE_DOWNLOAD = 8192,
    CLSCTX_NO_FAILURE_LOG = 16384,
    CLSCTX_DISABLE_AAA = 32768,
    CLSCTX_ENABLE_AAA = 65536,
    CLSCTX_FROM_DEFAULT_CONTEXT = 131072,
    CLSCTX_ACTIVATE_X86_SERVER = 262144,
    CLSCTX_ACTIVATE_32_BIT_SERVER = 262144,
    CLSCTX_ACTIVATE_64_BIT_SERVER = 524288,
    CLSCTX_ENABLE_CLOAKING = 1048576,
    CLSCTX_APPCONTAINER = 4194304,
    CLSCTX_ACTIVATE_AAA_AS_IU = 8388608,
    CLSCTX_RESERVED6 = 16777216,
    CLSCTX_ACTIVATE_ARM32_SERVER = 33554432,
    CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION = 67108864,
    CLSCTX_PS_DLL = 2147483648,
    CLSCTX_ALL = 23,
    CLSCTX_SERVER = 21,
}
