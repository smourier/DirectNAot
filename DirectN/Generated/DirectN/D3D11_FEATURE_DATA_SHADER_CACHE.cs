#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_shader_cache
public partial struct D3D11_FEATURE_DATA_SHADER_CACHE : IEquatable<D3D11_FEATURE_DATA_SHADER_CACHE>
{
    public static readonly D3D11_FEATURE_DATA_SHADER_CACHE Null = new();
    
    public uint SupportFlags;
    
    public D3D11_FEATURE_DATA_SHADER_CACHE(uint value) => this.SupportFlags = value;
    public override string ToString() => $"0x{SupportFlags:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_FEATURE_DATA_SHADER_CACHE value && Equals(value);
    public readonly bool Equals(D3D11_FEATURE_DATA_SHADER_CACHE other) => other.SupportFlags == SupportFlags;
    public override readonly int GetHashCode() => SupportFlags.GetHashCode();
    public static bool operator ==(D3D11_FEATURE_DATA_SHADER_CACHE left, D3D11_FEATURE_DATA_SHADER_CACHE right) => left.Equals(right);
    public static bool operator !=(D3D11_FEATURE_DATA_SHADER_CACHE left, D3D11_FEATURE_DATA_SHADER_CACHE right) => !left.Equals(right);
    public static implicit operator uint(D3D11_FEATURE_DATA_SHADER_CACHE value) => value.SupportFlags;
    public static implicit operator D3D11_FEATURE_DATA_SHADER_CACHE(uint value) => new(value);
}
