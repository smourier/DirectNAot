namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_pointer_position
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_OUTDUPL_POINTER_POSITION
{
    public POINT Position;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Visible;
}
