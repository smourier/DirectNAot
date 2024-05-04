﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-enumtypea
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMTYPEA
{
    public uint dwSize;
    public uint dwVersion;
    public uint dwFields;
    public PSTR pDeviceName;
    public uint dwMediaType;
    public uint dwDitheringMode;
    public InlineArrayUInt322 dwResolution;
    public uint dwCMMType;
    public uint dwClass;
    public uint dwDataColorSpace;
    public uint dwConnectionSpace;
    public uint dwSignature;
    public uint dwPlatform;
    public uint dwProfileFlags;
    public uint dwManufacturer;
    public uint dwModel;
    public InlineArrayUInt322 dwAttributes;
    public uint dwRenderingIntent;
    public uint dwCreator;
    public uint dwDeviceClass;
}
