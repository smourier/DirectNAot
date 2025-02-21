﻿#nullable enable
namespace DirectN;

[Flags]
public enum TRACK_POPUP_MENU_FLAGS : uint
{
    TPM_LEFTBUTTON = 0,
    TPM_RIGHTBUTTON = 2,
    TPM_LEFTALIGN = 0,
    TPM_CENTERALIGN = 4,
    TPM_RIGHTALIGN = 8,
    TPM_TOPALIGN = 0,
    TPM_VCENTERALIGN = 16,
    TPM_BOTTOMALIGN = 32,
    TPM_HORIZONTAL = 0,
    TPM_VERTICAL = 64,
    TPM_NONOTIFY = 128,
    TPM_RETURNCMD = 256,
    TPM_RECURSE = 1,
    TPM_HORPOSANIMATION = 1024,
    TPM_HORNEGANIMATION = 2048,
    TPM_VERPOSANIMATION = 4096,
    TPM_VERNEGANIMATION = 8192,
    TPM_NOANIMATION = 16384,
    TPM_LAYOUTRTL = 32768,
    TPM_WORKAREA = 65536,
}
