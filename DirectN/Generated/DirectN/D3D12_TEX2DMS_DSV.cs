#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2dms_dsv
public partial struct D3D12_TEX2DMS_DSV : IEquatable<D3D12_TEX2DMS_DSV>, IValueGet<uint>
{
    public static readonly D3D12_TEX2DMS_DSV Null = new();
    
    public uint UnusedField_NothingToDefine;
    
    public D3D12_TEX2DMS_DSV(uint value) => this.UnusedField_NothingToDefine = value;
    public override string ToString() => $"0x{UnusedField_NothingToDefine:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_TEX2DMS_DSV value && Equals(value);
    public readonly bool Equals(D3D12_TEX2DMS_DSV other) => other.UnusedField_NothingToDefine == UnusedField_NothingToDefine;
    public override readonly int GetHashCode() => UnusedField_NothingToDefine.GetHashCode();
    public static bool operator ==(D3D12_TEX2DMS_DSV left, D3D12_TEX2DMS_DSV right) => left.Equals(right);
    public static bool operator !=(D3D12_TEX2DMS_DSV left, D3D12_TEX2DMS_DSV right) => !left.Equals(right);
    public static implicit operator uint(D3D12_TEX2DMS_DSV value) => value.UnusedField_NothingToDefine;
    public static implicit operator D3D12_TEX2DMS_DSV(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => UnusedField_NothingToDefine;
    readonly object? IValueGet.GetValue() => UnusedField_NothingToDefine;
}
