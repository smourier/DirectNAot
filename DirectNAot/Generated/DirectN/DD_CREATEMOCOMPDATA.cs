namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createmocompdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CREATEMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpGuid;
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
    public nint lpData;
    public uint dwDataSize;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
