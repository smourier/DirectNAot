namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_2W
{
    public uint cVersion;
    public PWSTR pName;
    public PWSTR pEnvironment;
    public PWSTR pDriverPath;
    public PWSTR pDataFile;
    public PWSTR pConfigFile;
}
