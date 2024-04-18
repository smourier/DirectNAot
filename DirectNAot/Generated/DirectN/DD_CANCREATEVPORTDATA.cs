namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_cancreatevportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CANCREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CanCreateVideoPort;
}
