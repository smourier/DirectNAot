namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CANCREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CanCreateVideoPort;
}
