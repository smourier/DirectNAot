﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_ENDPOINT_SHARED_CREATE_PARAMS
{
    public uint u32Size;
    public uint u32TSSessionId;
    public EndpointConnectorType targetEndpointConnectorType;
    public WAVEFORMATEX wfxDeviceFormat;
}