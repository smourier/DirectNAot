namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/ns-wincodecsdk-wicmetadataheader
[StructLayout(LayoutKind.Sequential)]
public partial struct WICMetadataHeader
{
    public ulong Position;
    public uint Length;
    public nint Header;
    public ulong DataOffset;
}
