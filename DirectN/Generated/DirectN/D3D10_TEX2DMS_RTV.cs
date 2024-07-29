#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_tex2dms_rtv
public partial struct D3D10_TEX2DMS_RTV : IEquatable<D3D10_TEX2DMS_RTV>
{
    public static readonly D3D10_TEX2DMS_RTV Null = new();
    
    public uint UnusedField_NothingToDefine;
    
    public D3D10_TEX2DMS_RTV(uint value) => this.UnusedField_NothingToDefine = value;
    public override string ToString() => $"0x{UnusedField_NothingToDefine:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D10_TEX2DMS_RTV value && Equals(value);
    public readonly bool Equals(D3D10_TEX2DMS_RTV other) => other.UnusedField_NothingToDefine == UnusedField_NothingToDefine;
    public override readonly int GetHashCode() => UnusedField_NothingToDefine.GetHashCode();
    public static bool operator ==(D3D10_TEX2DMS_RTV left, D3D10_TEX2DMS_RTV right) => left.Equals(right);
    public static bool operator !=(D3D10_TEX2DMS_RTV left, D3D10_TEX2DMS_RTV right) => !left.Equals(right);
    public static implicit operator uint(D3D10_TEX2DMS_RTV value) => value.UnusedField_NothingToDefine;
    public static implicit operator D3D10_TEX2DMS_RTV(uint value) => new(value);
}
