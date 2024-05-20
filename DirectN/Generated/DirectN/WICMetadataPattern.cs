#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/ns-wincodecsdk-wicmetadatapattern
[StructLayout(LayoutKind.Sequential)]
public partial struct WICMetadataPattern
{
    public ulong Position;
    public uint Length;
    public nint Pattern;
    public nint Mask;
    public ulong DataOffset;
}
