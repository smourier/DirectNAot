#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct D3D12_VERSION_NUMBER
{
    [FieldOffset(0)]
    public ulong Version;
    
    [FieldOffset(0)]
    public InlineArrayUInt16_4 VersionParts;
}
