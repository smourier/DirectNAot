﻿#nullable enable
namespace DirectN;

[Flags]
public enum TASKDIALOG_COMMON_BUTTON_FLAGS
{
    TDCBF_OK_BUTTON = 1,
    TDCBF_YES_BUTTON = 2,
    TDCBF_NO_BUTTON = 4,
    TDCBF_CANCEL_BUTTON = 8,
    TDCBF_RETRY_BUTTON = 16,
    TDCBF_CLOSE_BUTTON = 32,
    TDCBF_ABORT_BUTTON = 65536,
    TDCBF_IGNORE_BUTTON = 131072,
    TDCBF_TRYAGAIN_BUTTON = 262144,
    TDCBF_CONTINUE_BUTTON = 524288,
    TDCBF_HELP_BUTTON = 1048576,
}
