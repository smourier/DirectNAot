#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_cpu_descriptor_handle
public partial struct D3D12_CPU_DESCRIPTOR_HANDLE : IEquatable<D3D12_CPU_DESCRIPTOR_HANDLE>, IValueGet<nuint>
{
    public static readonly D3D12_CPU_DESCRIPTOR_HANDLE Null = new();
    
    public nuint ptr;
    
    public D3D12_CPU_DESCRIPTOR_HANDLE(nuint value) => this.ptr = value;
    public override string ToString() => $"0x{ptr:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_CPU_DESCRIPTOR_HANDLE value && Equals(value);
    public readonly bool Equals(D3D12_CPU_DESCRIPTOR_HANDLE other) => other.ptr == ptr;
    public override readonly int GetHashCode() => ptr.GetHashCode();
    public static bool operator ==(D3D12_CPU_DESCRIPTOR_HANDLE left, D3D12_CPU_DESCRIPTOR_HANDLE right) => left.Equals(right);
    public static bool operator !=(D3D12_CPU_DESCRIPTOR_HANDLE left, D3D12_CPU_DESCRIPTOR_HANDLE right) => !left.Equals(right);
    public static implicit operator nuint(D3D12_CPU_DESCRIPTOR_HANDLE value) => value.ptr;
    public static implicit operator D3D12_CPU_DESCRIPTOR_HANDLE(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => ptr;
    readonly object? IValueGet.GetValue() => ptr;
}
