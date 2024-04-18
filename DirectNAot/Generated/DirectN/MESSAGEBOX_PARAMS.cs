namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MESSAGEBOX_PARAMS
{
    public uint cbSize;
    public PWSTR pTitle;
    public PWSTR pMessage;
    public uint Style;
    public uint dwTimeout;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bWait;
}
