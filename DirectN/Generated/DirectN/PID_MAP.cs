﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/pid-map
public partial struct PID_MAP
{
    public uint ulPID;
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
}
