namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-5
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_5W
{
    public uint cVersion;
    public PWSTR pName;
    public PWSTR pEnvironment;
    public PWSTR pDriverPath;
    public PWSTR pDataFile;
    public PWSTR pConfigFile;
    public uint dwDriverAttributes;
    public uint dwConfigVersion;
    public uint dwDriverVersion;
}
