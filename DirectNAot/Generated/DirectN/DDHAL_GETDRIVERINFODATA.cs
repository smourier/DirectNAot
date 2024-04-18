namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETDRIVERINFODATA
{
    public uint dwSize;
    public uint dwFlags;
    public Guid guidInfo;
    public uint dwExpectedSize;
    public nint lpvData;
    public uint dwActualSize;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nuint dwContext;
}
