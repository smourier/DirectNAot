#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/ns-dxgi1_3-dxgi_decode_swap_chain_desc
public partial struct DXGI_DECODE_SWAP_CHAIN_DESC : IEquatable<DXGI_DECODE_SWAP_CHAIN_DESC>
{
    public static readonly DXGI_DECODE_SWAP_CHAIN_DESC Null = new();
    
    public uint Flags;
    
    public DXGI_DECODE_SWAP_CHAIN_DESC(uint value) => this.Flags = value;
    public override string ToString() => $"0x{Flags:x}";
    
    public override readonly bool Equals(object? obj) => obj is DXGI_DECODE_SWAP_CHAIN_DESC value && Equals(value);
    public readonly bool Equals(DXGI_DECODE_SWAP_CHAIN_DESC other) => other.Flags == Flags;
    public override readonly int GetHashCode() => Flags.GetHashCode();
    public static bool operator ==(DXGI_DECODE_SWAP_CHAIN_DESC left, DXGI_DECODE_SWAP_CHAIN_DESC right) => left.Equals(right);
    public static bool operator !=(DXGI_DECODE_SWAP_CHAIN_DESC left, DXGI_DECODE_SWAP_CHAIN_DESC right) => !left.Equals(right);
    public static implicit operator uint(DXGI_DECODE_SWAP_CHAIN_DESC value) => value.Flags;
    public static implicit operator DXGI_DECODE_SWAP_CHAIN_DESC(uint value) => new(value);
}
