namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3draster-status
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DRASTER_STATUS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool InVBlank;
    public uint ScanLine;
}
