﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CAMERACONTROL_NODE_S
{
    public KSP_NODE NodeProperty;
    public int Value;
    public uint Flags;
    public uint Capabilities;
}