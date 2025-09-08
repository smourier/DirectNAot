#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_postbuild_info_compacted_size_desc
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC : IEquatable<D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC>, IValueGet<ulong>
{
    public static readonly D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC Null = new();
    
    public ulong CompactedSizeInBytes;
    
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC(ulong value) => this.CompactedSizeInBytes = value;
    public override readonly string ToString() => $"0x{CompactedSizeInBytes:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC value && Equals(value);
    public readonly bool Equals(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC other) => other.CompactedSizeInBytes == CompactedSizeInBytes;
    public override readonly int GetHashCode() => CompactedSizeInBytes.GetHashCode();
    public static bool operator ==(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC left, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC right) => left.Equals(right);
    public static bool operator !=(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC left, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC right) => !left.Equals(right);
    public static implicit operator ulong(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC value) => value.CompactedSizeInBytes;
    public static implicit operator D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => CompactedSizeInBytes;
    readonly object? IValueGet.GetValue() => CompactedSizeInBytes;
}
