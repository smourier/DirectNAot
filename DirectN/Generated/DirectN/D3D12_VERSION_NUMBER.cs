#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct D3D12_VERSION_NUMBER
{
    public struct D3D12_VERSION_NUMBER_COMPONENTS
    {
        public ushort Revision;
        public ushort Build;
        public ushort Minor;
        public ushort Major;
    }
    
    [FieldOffset(0)]
    public ulong Version;
    
    [FieldOffset(0)]
    public D3D12_VERSION_NUMBER_COMPONENTS Components;
    
    [FieldOffset(0)]
    public InlineArrayUInt16_4 VersionParts;
}
