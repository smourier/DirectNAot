namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-6
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_6A
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
    public PSTR pszzPreviousNames;
    public FILETIME ftDriverDate;
    public ulong dwlDriverVersion;
    public PSTR pszMfgName;
    public PSTR pszOEMUrl;
    public PSTR pszHardwareID;
    public PSTR pszProvider;
}
