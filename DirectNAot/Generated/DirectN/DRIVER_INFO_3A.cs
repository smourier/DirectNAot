﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_3A
{
    public uint cVersion;
    public PSTR pName;
    public PSTR pEnvironment;
    public PSTR pDriverPath;
    public PSTR pDataFile;
    public PSTR pConfigFile;
    public PSTR pHelpFile;
    public PSTR pDependentFiles;
    public PSTR pMonitorName;
    public PSTR pDefaultDataType;
}
