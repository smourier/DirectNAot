namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-8
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_8W
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
    public PWSTR pszPrintProcessor;
    public PWSTR pszVendorSetup;
    public PWSTR pszzColorProfiles;
    public PWSTR pszInfPath;
    public uint dwPrinterDriverAttributes;
    public PWSTR pszzCoreDriverDependencies;
    public FILETIME ftMinInboxDriverVerDate;
    public ulong dwlMinInboxDriverVerVersion;
}
