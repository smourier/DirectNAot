﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_ANIM_WINDOW_PARMSW
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PWSTR lpstrText;
}
