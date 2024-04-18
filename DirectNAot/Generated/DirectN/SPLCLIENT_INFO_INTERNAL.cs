namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPLCLIENT_INFO_INTERNAL
{
    public uint cbSize;
    public uint dwFlags;
    public uint dwSize;
    public PWSTR pMachineName;
    public PWSTR pUserName;
    public uint dwBuildNum;
    public uint dwMajorVersion;
    public uint dwMinorVersion;
    public ushort wProcessorArchitecture;
    public ulong hSplPrinter;
    public uint dwProcessId;
    public uint dwSessionId;
}
