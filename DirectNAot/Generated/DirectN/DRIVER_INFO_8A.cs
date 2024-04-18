namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-8
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_8A
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
    public PSTR pszPrintProcessor;
    public PSTR pszVendorSetup;
    public PSTR pszzColorProfiles;
    public PSTR pszInfPath;
    public uint dwPrinterDriverAttributes;
    public PSTR pszzCoreDriverDependencies;
    public FILETIME ftMinInboxDriverVerDate;
    public ulong dwlMinInboxDriverVerVersion;
}
