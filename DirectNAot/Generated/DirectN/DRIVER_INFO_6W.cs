namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-6
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_6W
{
    public uint cVersion;
    public PWSTR pName;
    public PWSTR pEnvironment;
    public PWSTR pDriverPath;
    public PWSTR pDataFile;
    public PWSTR pConfigFile;
    public PWSTR pHelpFile;
    public PWSTR pDependentFiles;
    public PWSTR pMonitorName;
    public PWSTR pDefaultDataType;
    public PWSTR pszzPreviousNames;
    public FILETIME ftDriverDate;
    public ulong dwlDriverVersion;
    public PWSTR pszMfgName;
    public PWSTR pszOEMUrl;
    public PWSTR pszHardwareID;
    public PWSTR pszProvider;
}
