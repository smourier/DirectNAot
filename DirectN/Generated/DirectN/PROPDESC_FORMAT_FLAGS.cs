﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_format_flags
[Flags]
public enum PROPDESC_FORMAT_FLAGS
{
    PDFF_DEFAULT = 0,
    PDFF_PREFIXNAME = 1,
    PDFF_FILENAME = 2,
    PDFF_ALWAYSKB = 4,
    PDFF_RESERVED_RIGHTTOLEFT = 8,
    PDFF_SHORTTIME = 16,
    PDFF_LONGTIME = 32,
    PDFF_HIDETIME = 64,
    PDFF_SHORTDATE = 128,
    PDFF_LONGDATE = 256,
    PDFF_HIDEDATE = 512,
    PDFF_RELATIVEDATE = 1024,
    PDFF_USEEDITINVITATION = 2048,
    PDFF_READONLY = 4096,
    PDFF_NOAUTOREADINGORDER = 8192,
}
