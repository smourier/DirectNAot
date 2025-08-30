#nullable enable
namespace DirectN;

public partial struct D3D12_TEX2DMS_UAV : IEquatable<D3D12_TEX2DMS_UAV>, IValueGet<uint>
{
    public static readonly D3D12_TEX2DMS_UAV Null = new();
    
    public uint UnusedField_NothingToDefine;
    
    public D3D12_TEX2DMS_UAV(uint value) => this.UnusedField_NothingToDefine = value;
    public override string ToString() => $"0x{UnusedField_NothingToDefine:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_TEX2DMS_UAV value && Equals(value);
    public readonly bool Equals(D3D12_TEX2DMS_UAV other) => other.UnusedField_NothingToDefine == UnusedField_NothingToDefine;
    public override readonly int GetHashCode() => UnusedField_NothingToDefine.GetHashCode();
    public static bool operator ==(D3D12_TEX2DMS_UAV left, D3D12_TEX2DMS_UAV right) => left.Equals(right);
    public static bool operator !=(D3D12_TEX2DMS_UAV left, D3D12_TEX2DMS_UAV right) => !left.Equals(right);
    public static implicit operator uint(D3D12_TEX2DMS_UAV value) => value.UnusedField_NothingToDefine;
    public static implicit operator D3D12_TEX2DMS_UAV(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => UnusedField_NothingToDefine;
    readonly object? IValueGet.GetValue() => UnusedField_NothingToDefine;
}
