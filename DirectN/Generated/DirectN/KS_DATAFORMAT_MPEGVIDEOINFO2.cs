﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATAFORMAT_MPEGVIDEOINFO2
{
    public KSDATAFORMAT DataFormat;
    public KS_MPEGVIDEOINFO2 MpegVideoInfoHeader2;
}