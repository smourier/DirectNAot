﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dadapter-identifier9
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DADAPTER_IDENTIFIER9
{
    public InlineArrayCHAR512 Driver;
    public InlineArrayCHAR512 Description;
    public InlineArrayFoundationCHAR32 DeviceName;
    public long DriverVersion;
    public uint VendorId;
    public uint DeviceId;
    public uint SubSysId;
    public uint Revision;
    public Guid DeviceIdentifier;
    public uint WHQLLevel;
}
