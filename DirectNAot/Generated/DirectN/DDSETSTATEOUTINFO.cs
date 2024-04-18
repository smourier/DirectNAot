namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddsetstateoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSETSTATEOUTINFO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool bSoftwareAutoflip;
    public uint dwSurfaceIndex;
    public uint dwVBISurfaceIndex;
}
