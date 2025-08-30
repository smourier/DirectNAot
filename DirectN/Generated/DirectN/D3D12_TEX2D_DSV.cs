#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2d_dsv
public partial struct D3D12_TEX2D_DSV : IEquatable<D3D12_TEX2D_DSV>, IValueGet<uint>
{
    public static readonly D3D12_TEX2D_DSV Null = new();
    
    public uint MipSlice;
    
    public D3D12_TEX2D_DSV(uint value) => this.MipSlice = value;
    public override string ToString() => $"0x{MipSlice:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_TEX2D_DSV value && Equals(value);
    public readonly bool Equals(D3D12_TEX2D_DSV other) => other.MipSlice == MipSlice;
    public override readonly int GetHashCode() => MipSlice.GetHashCode();
    public static bool operator ==(D3D12_TEX2D_DSV left, D3D12_TEX2D_DSV right) => left.Equals(right);
    public static bool operator !=(D3D12_TEX2D_DSV left, D3D12_TEX2D_DSV right) => !left.Equals(right);
    public static implicit operator uint(D3D12_TEX2D_DSV value) => value.MipSlice;
    public static implicit operator D3D12_TEX2D_DSV(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MipSlice;
    readonly object? IValueGet.GetValue() => MipSlice;
}
