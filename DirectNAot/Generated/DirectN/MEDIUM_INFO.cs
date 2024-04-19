namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MEDIUM_INFO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool MediaPresent;
    public uint MediaType;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool RecordInhibit;
}
