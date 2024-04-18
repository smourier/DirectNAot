namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddkernel/ns-ddkernel-ddkernelcaps
[StructLayout(LayoutKind.Sequential)]
public partial struct DDKERNELCAPS
{
    public uint dwSize;
    public uint dwCaps;
    public uint dwIRQCaps;
}
