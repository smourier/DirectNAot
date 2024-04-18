namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPLCLIENT_INFO_1
{
    public uint dwSize;
    public PWSTR pMachineName;
    public PWSTR pUserName;
    public uint dwBuildNum;
    public uint dwMajorVersion;
    public uint dwMinorVersion;
    public ushort wProcessorArchitecture;
}
