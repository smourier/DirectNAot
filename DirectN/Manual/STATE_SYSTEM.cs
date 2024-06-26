﻿namespace DirectN;

[Flags]
public enum STATE_SYSTEM
{
    STATE_SYSTEM_NONE = 0x0,
    STATE_SYSTEM_UNAVAILABLE = 0x1,
    STATE_SYSTEM_SELECTED = 0x2,
    STATE_SYSTEM_FOCUSED = 0x4,
    STATE_SYSTEM_PRESSED = 0x8,
    STATE_SYSTEM_CHECKED = 0x10,
    STATE_SYSTEM_MIXED = 0x20,
    STATE_SYSTEM_INDETERMINATE = STATE_SYSTEM_MIXED,
    STATE_SYSTEM_READONLY = 0x40,
    STATE_SYSTEM_HOTTRACKED = 0x80,
    STATE_SYSTEM_DEFAULT = 0x100,
    STATE_SYSTEM_EXPANDED = 0x200,
    STATE_SYSTEM_COLLAPSED = 0x400,
    STATE_SYSTEM_BUSY = 0x800,
    STATE_SYSTEM_FLOATING = 0x1000,
    STATE_SYSTEM_MARQUEED = 0x2000,
    STATE_SYSTEM_ANIMATED = 0x4000,
    STATE_SYSTEM_INVISIBLE = 0x8000,
    STATE_SYSTEM_OFFSCREEN = 0x10000,
    STATE_SYSTEM_SIZEABLE = 0x20000,
    STATE_SYSTEM_MOVEABLE = 0x40000,
    STATE_SYSTEM_SELFVOICING = 0x80000,
    STATE_SYSTEM_FOCUSABLE = 0x100000,
    STATE_SYSTEM_SELECTABLE = 0x200000,
    STATE_SYSTEM_LINKED = 0x400000,
    STATE_SYSTEM_TRAVERSED = 0x800000,
    STATE_SYSTEM_MULTISELECTABLE = 0x1000000,
    STATE_SYSTEM_EXTSELECTABLE = 0x2000000,
    STATE_SYSTEM_ALERT_LOW = 0x4000000,
    STATE_SYSTEM_ALERT_MEDIUM = 0x8000000,
    STATE_SYSTEM_ALERT_HIGH = 0x10000000,
    STATE_SYSTEM_PROTECTED = 0x20000000,
    STATE_SYSTEM_VALID = 0x3fffffff
}
