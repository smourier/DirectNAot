﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_ANIM_WINDOW_PARMSA
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PSTR lpstrText;
}
