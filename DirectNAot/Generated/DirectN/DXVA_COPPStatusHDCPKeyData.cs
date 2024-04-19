namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppstatushdcpkeydata
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPStatusHDCPKeyData
{
    public Guid rApp;
    public uint dwFlags;
    public uint dwHDCPFlags;
    public Guid BKey;
    public Guid Reserved1;
    public Guid Reserved2;
}
