namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportsignaldata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETVPORTSIGNALDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwStatus;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoSignalStatus;
}
