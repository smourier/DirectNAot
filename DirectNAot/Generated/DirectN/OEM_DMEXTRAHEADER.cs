namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEM_DMEXTRAHEADER
{
    public uint dwSize;
    public uint dwSignature;
    public uint dwVersion;
}
