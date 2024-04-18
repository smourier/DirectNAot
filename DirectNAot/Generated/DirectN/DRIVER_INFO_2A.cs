namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_2A
{
    public uint cVersion;
    public PSTR pName;
    public PSTR pEnvironment;
    public PSTR pDriverPath;
    public PSTR pDataFile;
    public PSTR pConfigFile;
}
