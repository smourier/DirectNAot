namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOCEVENT_CREATEDCPRE
{
    public PWSTR pszDriver;
    public PWSTR pszDevice;
    public nint pdm;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bIC;
}
