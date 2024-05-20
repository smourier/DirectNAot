﻿#nullable enable
namespace DirectN;

[Flags]
public enum PROPVAR_CHANGE_FLAGS
{
    PVCHF_DEFAULT = 0,
    PVCHF_NOVALUEPROP = 1,
    PVCHF_ALPHABOOL = 2,
    PVCHF_NOUSEROVERRIDE = 4,
    PVCHF_LOCALBOOL = 8,
    PVCHF_NOHEXSTRING = 16,
}
