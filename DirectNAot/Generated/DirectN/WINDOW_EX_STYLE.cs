﻿namespace DirectN;

[Flags]
public enum WINDOW_EX_STYLE : uint
{
    WS_EX_DLGMODALFRAME = 1,
    WS_EX_NOPARENTNOTIFY = 4,
    WS_EX_TOPMOST = 8,
    WS_EX_ACCEPTFILES = 16,
    WS_EX_TRANSPARENT = 32,
    WS_EX_MDICHILD = 64,
    WS_EX_TOOLWINDOW = 128,
    WS_EX_WINDOWEDGE = 256,
    WS_EX_CLIENTEDGE = 512,
    WS_EX_CONTEXTHELP = 1024,
    WS_EX_RIGHT = 4096,
    WS_EX_LEFT = 0,
    WS_EX_RTLREADING = 8192,
    WS_EX_LTRREADING = 0,
    WS_EX_LEFTSCROLLBAR = 16384,
    WS_EX_RIGHTSCROLLBAR = 0,
    WS_EX_CONTROLPARENT = 65536,
    WS_EX_STATICEDGE = 131072,
    WS_EX_APPWINDOW = 262144,
    WS_EX_OVERLAPPEDWINDOW = 768,
    WS_EX_PALETTEWINDOW = 392,
    WS_EX_LAYERED = 524288,
    WS_EX_NOINHERITLAYOUT = 1048576,
    WS_EX_NOREDIRECTIONBITMAP = 2097152,
    WS_EX_LAYOUTRTL = 4194304,
    WS_EX_COMPOSITED = 33554432,
    WS_EX_NOACTIVATE = 134217728,
}
