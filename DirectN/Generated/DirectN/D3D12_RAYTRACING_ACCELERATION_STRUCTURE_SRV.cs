#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_srv
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV : IEquatable<D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV>, IValueGet<ulong>
{
    public static readonly D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV Null = new();
    
    public ulong Location;
    
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV(ulong value) => this.Location = value;
    public override string ToString() => $"0x{Location:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV value && Equals(value);
    public readonly bool Equals(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV other) => other.Location == Location;
    public override readonly int GetHashCode() => Location.GetHashCode();
    public static bool operator ==(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV left, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV right) => left.Equals(right);
    public static bool operator !=(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV left, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV right) => !left.Equals(right);
    public static implicit operator ulong(D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV value) => value.Location;
    public static implicit operator D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => Location;
    readonly object? IValueGet.GetValue() => Location;
}
