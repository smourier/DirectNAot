#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex2d_vdov
public partial struct D3D11_TEX2D_VDOV : IEquatable<D3D11_TEX2D_VDOV>
{
    public static readonly D3D11_TEX2D_VDOV Null = new();
    
    public uint ArraySlice;
    
    public D3D11_TEX2D_VDOV(uint value) => this.ArraySlice = value;
    public override string ToString() => $"0x{ArraySlice:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_TEX2D_VDOV value && Equals(value);
    public readonly bool Equals(D3D11_TEX2D_VDOV other) => other.ArraySlice == ArraySlice;
    public override readonly int GetHashCode() => ArraySlice.GetHashCode();
    public static bool operator ==(D3D11_TEX2D_VDOV left, D3D11_TEX2D_VDOV right) => left.Equals(right);
    public static bool operator !=(D3D11_TEX2D_VDOV left, D3D11_TEX2D_VDOV right) => !left.Equals(right);
    public static implicit operator uint(D3D11_TEX2D_VDOV value) => value.ArraySlice;
    public static implicit operator D3D11_TEX2D_VDOV(uint value) => new(value);
}
