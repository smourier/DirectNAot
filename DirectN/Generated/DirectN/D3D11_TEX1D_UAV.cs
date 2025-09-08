#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex1d_uav
public partial struct D3D11_TEX1D_UAV : IEquatable<D3D11_TEX1D_UAV>, IValueGet<uint>
{
    public static readonly D3D11_TEX1D_UAV Null = new();
    
    public uint MipSlice;
    
    public D3D11_TEX1D_UAV(uint value) => this.MipSlice = value;
    public override readonly string ToString() => $"0x{MipSlice:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_TEX1D_UAV value && Equals(value);
    public readonly bool Equals(D3D11_TEX1D_UAV other) => other.MipSlice == MipSlice;
    public override readonly int GetHashCode() => MipSlice.GetHashCode();
    public static bool operator ==(D3D11_TEX1D_UAV left, D3D11_TEX1D_UAV right) => left.Equals(right);
    public static bool operator !=(D3D11_TEX1D_UAV left, D3D11_TEX1D_UAV right) => !left.Equals(right);
    public static implicit operator uint(D3D11_TEX1D_UAV value) => value.MipSlice;
    public static implicit operator D3D11_TEX1D_UAV(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MipSlice;
    readonly object? IValueGet.GetValue() => MipSlice;
}
