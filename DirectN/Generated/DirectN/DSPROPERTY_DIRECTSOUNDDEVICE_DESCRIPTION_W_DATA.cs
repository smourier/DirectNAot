﻿#nullable enable
namespace DirectN;

public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA
{
    public DIRECTSOUNDDEVICE_TYPE Type;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public Guid DeviceId;
    public PWSTR Description;
    public PWSTR Module;
    public PWSTR Interface;
    public uint WaveDeviceId;
}
