#nullable enable
namespace DirectN;

public partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC : IEquatable<D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC>, IValueGet<ulong>
{
    public static readonly D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC Null = new();
    
    public ulong CurrentSizeInBytes;
    
    public D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC(ulong value) => this.CurrentSizeInBytes = value;
    public override readonly string ToString() => $"0x{CurrentSizeInBytes:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC value && Equals(value);
    public readonly bool Equals(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC other) => other.CurrentSizeInBytes == CurrentSizeInBytes;
    public override readonly int GetHashCode() => CurrentSizeInBytes.GetHashCode();
    public static bool operator ==(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC left, D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC right) => left.Equals(right);
    public static bool operator !=(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC left, D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC right) => !left.Equals(right);
    public static implicit operator ulong(D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC value) => value.CurrentSizeInBytes;
    public static implicit operator D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => CurrentSizeInBytes;
    readonly object? IValueGet.GetValue() => CurrentSizeInBytes;
}
