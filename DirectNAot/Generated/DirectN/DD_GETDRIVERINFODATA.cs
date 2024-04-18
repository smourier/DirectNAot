namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getdriverinfodata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETDRIVERINFODATA
{
    public nint dhpdev;
    public uint dwSize;
    public uint dwFlags;
    public Guid guidInfo;
    public uint dwExpectedSize;
    public nint lpvData;
    public uint dwActualSize;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
