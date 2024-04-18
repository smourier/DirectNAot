namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-4
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_4W
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
}
