#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9caps/ns-d3d9caps-d3dcontentprotectioncaps
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCONTENTPROTECTIONCAPS
{
    public uint Caps;
    public Guid KeyExchangeType;
    public uint BufferAlignmentStart;
    public uint BlockAlignmentSize;
    public ulong ProtectedMemorySize;
}
