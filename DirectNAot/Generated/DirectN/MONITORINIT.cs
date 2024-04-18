namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORINIT
{
    public uint cbSize;
    public HANDLE hSpooler;
    public HKEY hckRegistryRoot;
    public nint pMonitorReg;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bLocal;
    public PWSTR pszServerName;
}
