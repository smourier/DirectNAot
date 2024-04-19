namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CANCREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    public HRESULT ddRVal;
    public nint CanCreateVideoPort;
}
