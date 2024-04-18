namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_destroyvportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroyVideoPort;
}
