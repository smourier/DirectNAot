namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_WAITFORVPORTSYNCDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public uint dwLine;
    public uint dwTimeOut;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint WaitForVideoPortSync;
}
