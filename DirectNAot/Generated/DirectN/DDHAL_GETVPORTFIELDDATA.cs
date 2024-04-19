namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTFIELDDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bField;
    public HRESULT ddRVal;
    public nint GetVideoPortField;
}
