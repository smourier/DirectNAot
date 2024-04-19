﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_CAPTURESTATS
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public uint Flags;
    public uint Reserved;
    public ulong ExposureTime;
    public ulong ExposureCompensationFlags;
    public int ExposureCompensationValue;
    public uint IsoSpeed;
    public uint FocusState;
    public uint LensPosition;
    public uint WhiteBalance;
    public uint Flash;
    public uint FlashPower;
    public uint ZoomFactor;
    public ulong SceneMode;
    public ulong SensorFramerate;
}
