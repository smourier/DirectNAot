namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTSTATUS
{
    public uint dwSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bInUse;
    public uint dwFlags;
    public uint dwReserved1;
    public DDVIDEOPORTCONNECT VideoPortType;
    public nuint dwReserved2;
    public nuint dwReserved3;
}
