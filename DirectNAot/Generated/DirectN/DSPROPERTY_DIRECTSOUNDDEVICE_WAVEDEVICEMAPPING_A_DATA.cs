﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A_DATA
{
    public PSTR DeviceName;
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow;
    public Guid DeviceId;
}
