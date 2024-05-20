﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_timing_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DWM_TIMING_INFO
{
    public uint cbSize;
    public UNSIGNED_RATIO rateRefresh;
    public ulong qpcRefreshPeriod;
    public UNSIGNED_RATIO rateCompose;
    public ulong qpcVBlank;
    public ulong cRefresh;
    public uint cDXRefresh;
    public ulong qpcCompose;
    public ulong cFrame;
    public uint cDXPresent;
    public ulong cRefreshFrame;
    public ulong cFrameSubmitted;
    public uint cDXPresentSubmitted;
    public ulong cFrameConfirmed;
    public uint cDXPresentConfirmed;
    public ulong cRefreshConfirmed;
    public uint cDXRefreshConfirmed;
    public ulong cFramesLate;
    public uint cFramesOutstanding;
    public ulong cFrameDisplayed;
    public ulong qpcFrameDisplayed;
    public ulong cRefreshFrameDisplayed;
    public ulong cFrameComplete;
    public ulong qpcFrameComplete;
    public ulong cFramePending;
    public ulong qpcFramePending;
    public ulong cFramesDisplayed;
    public ulong cFramesComplete;
    public ulong cFramesPending;
    public ulong cFramesAvailable;
    public ulong cFramesDropped;
    public ulong cFramesMissed;
    public ulong cRefreshNextDisplayed;
    public ulong cRefreshNextPresented;
    public ulong cRefreshesDisplayed;
    public ulong cRefreshesPresented;
    public ulong cRefreshStarted;
    public ulong cPixelsReceived;
    public ulong cPixelsDrawn;
    public ulong cBuffersEmpty;
}
