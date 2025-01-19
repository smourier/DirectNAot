﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_view_flags
[Flags]
public enum PROPDESC_VIEW_FLAGS
{
    PDVF_DEFAULT = 0,
    PDVF_CENTERALIGN = 1,
    PDVF_RIGHTALIGN = 2,
    PDVF_BEGINNEWGROUP = 4,
    PDVF_FILLAREA = 8,
    PDVF_SORTDESCENDING = 16,
    PDVF_SHOWONLYIFPRESENT = 32,
    PDVF_SHOWBYDEFAULT = 64,
    PDVF_SHOWINPRIMARYLIST = 128,
    PDVF_SHOWINSECONDARYLIST = 256,
    PDVF_HIDELABEL = 512,
    PDVF_HIDDEN = 2048,
    PDVF_CANWRAP = 4096,
    PDVF_MASK_ALL = 7167,
}
