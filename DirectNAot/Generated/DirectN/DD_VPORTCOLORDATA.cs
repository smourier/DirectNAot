namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_vportcolordata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_VPORTCOLORDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpColorData;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint ColorControl;
}
