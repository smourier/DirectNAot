namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-5
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_5A
{
    public uint cVersion;
    public PSTR pName;
    public PSTR pEnvironment;
    public PSTR pDriverPath;
    public PSTR pDataFile;
    public PSTR pConfigFile;
    public uint dwDriverAttributes;
    public uint dwConfigVersion;
    public uint dwDriverVersion;
}
