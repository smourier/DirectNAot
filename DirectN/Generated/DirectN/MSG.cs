﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-msg
public partial struct MSG
{
    public HWND hwnd;
    public uint message;
    public WPARAM wParam;
    public LPARAM lParam;
    public uint time;
    public POINT pt;
}
