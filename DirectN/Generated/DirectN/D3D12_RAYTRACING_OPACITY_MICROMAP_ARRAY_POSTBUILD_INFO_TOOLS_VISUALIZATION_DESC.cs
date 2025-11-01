#nullable enable
namespace DirectN;

public partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC : IEquatable<D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC>, IValueGet<ulong>
{
    public static readonly D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC Null = new();
    
    public ulong DecodedSizeInBytes;
    
    public D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC(ulong value) => this.DecodedSizeInBytes = value;
    public override readonly string ToString() => $"0x{DecodedSizeInBytes:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC value && Equals(value);
    public readonly bool Equals(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC other) => other.DecodedSizeInBytes == DecodedSizeInBytes;
    public override readonly int GetHashCode() => DecodedSizeInBytes.GetHashCode();
    public static bool operator ==(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC left, D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC right) => left.Equals(right);
    public static bool operator !=(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC left, D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC right) => !left.Equals(right);
    public static implicit operator ulong(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC value) => value.DecodedSizeInBytes;
    public static implicit operator D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => DecodedSizeInBytes;
    readonly object? IValueGet.GetValue() => DecodedSizeInBytes;
}
