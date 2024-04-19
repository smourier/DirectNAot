﻿namespace DirectN;

public enum DEVPROPTYPE : uint
{
    DEVPROP_TYPEMOD_ARRAY = 4096,
    DEVPROP_TYPEMOD_LIST = 8192,
    DEVPROP_TYPE_EMPTY = 0,
    DEVPROP_TYPE_NULL = 1,
    DEVPROP_TYPE_SBYTE = 2,
    DEVPROP_TYPE_BYTE = 3,
    DEVPROP_TYPE_INT16 = 4,
    DEVPROP_TYPE_UINT16 = 5,
    DEVPROP_TYPE_INT32 = 6,
    DEVPROP_TYPE_UINT32 = 7,
    DEVPROP_TYPE_INT64 = 8,
    DEVPROP_TYPE_UINT64 = 9,
    DEVPROP_TYPE_FLOAT = 10,
    DEVPROP_TYPE_DOUBLE = 11,
    DEVPROP_TYPE_DECIMAL = 12,
    DEVPROP_TYPE_GUID = 13,
    DEVPROP_TYPE_CURRENCY = 14,
    DEVPROP_TYPE_DATE = 15,
    DEVPROP_TYPE_FILETIME = 16,
    DEVPROP_TYPE_BOOLEAN = 17,
    DEVPROP_TYPE_STRING = 18,
    DEVPROP_TYPE_STRING_LIST = 8210,
    DEVPROP_TYPE_SECURITY_DESCRIPTOR = 19,
    DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = 20,
    DEVPROP_TYPE_DEVPROPKEY = 21,
    DEVPROP_TYPE_DEVPROPTYPE = 22,
    DEVPROP_TYPE_BINARY = 4099,
    DEVPROP_TYPE_ERROR = 23,
    DEVPROP_TYPE_NTSTATUS = 24,
    DEVPROP_TYPE_STRING_INDIRECT = 25,
}
