﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_info
public partial struct POINTER_INFO
{
    public POINTER_INPUT_TYPE pointerType;
    public uint pointerId;
    public uint frameId;
    public POINTER_FLAGS pointerFlags;
    public HANDLE sourceDevice;
    public HWND hwndTarget;
    public POINT ptPixelLocation;
    public POINT ptHimetricLocation;
    public POINT ptPixelLocationRaw;
    public POINT ptHimetricLocationRaw;
    public uint dwTime;
    public uint historyCount;
    public int InputData;
    public uint dwKeyStates;
    public ulong PerformanceCount;
    public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
}
