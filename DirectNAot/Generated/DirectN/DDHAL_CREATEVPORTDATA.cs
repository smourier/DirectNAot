namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    public nint lpVideoPort;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CreateVideoPort;
}
