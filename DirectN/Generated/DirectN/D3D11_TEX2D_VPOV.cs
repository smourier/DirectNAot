#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex2d_vpov
public partial struct D3D11_TEX2D_VPOV : IEquatable<D3D11_TEX2D_VPOV>
{
    public static readonly D3D11_TEX2D_VPOV Null = new();
    
    public uint MipSlice;
    
    public D3D11_TEX2D_VPOV(uint value) => this.MipSlice = value;
    public override string ToString() => $"0x{MipSlice:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_TEX2D_VPOV value && Equals(value);
    public readonly bool Equals(D3D11_TEX2D_VPOV other) => other.MipSlice == MipSlice;
    public override readonly int GetHashCode() => MipSlice.GetHashCode();
    public static bool operator ==(D3D11_TEX2D_VPOV left, D3D11_TEX2D_VPOV right) => left.Equals(right);
    public static bool operator !=(D3D11_TEX2D_VPOV left, D3D11_TEX2D_VPOV right) => !left.Equals(right);
    public static implicit operator uint(D3D11_TEX2D_VPOV value) => value.MipSlice;
    public static implicit operator D3D11_TEX2D_VPOV(uint value) => new(value);
}
