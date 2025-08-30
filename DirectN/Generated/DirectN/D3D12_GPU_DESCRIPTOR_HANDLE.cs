#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_gpu_descriptor_handle
public partial struct D3D12_GPU_DESCRIPTOR_HANDLE : IEquatable<D3D12_GPU_DESCRIPTOR_HANDLE>, IValueGet<ulong>
{
    public static readonly D3D12_GPU_DESCRIPTOR_HANDLE Null = new();
    
    public ulong ptr;
    
    public D3D12_GPU_DESCRIPTOR_HANDLE(ulong value) => this.ptr = value;
    public override string ToString() => $"0x{ptr:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_GPU_DESCRIPTOR_HANDLE value && Equals(value);
    public readonly bool Equals(D3D12_GPU_DESCRIPTOR_HANDLE other) => other.ptr == ptr;
    public override readonly int GetHashCode() => ptr.GetHashCode();
    public static bool operator ==(D3D12_GPU_DESCRIPTOR_HANDLE left, D3D12_GPU_DESCRIPTOR_HANDLE right) => left.Equals(right);
    public static bool operator !=(D3D12_GPU_DESCRIPTOR_HANDLE left, D3D12_GPU_DESCRIPTOR_HANDLE right) => !left.Equals(right);
    public static implicit operator ulong(D3D12_GPU_DESCRIPTOR_HANDLE value) => value.ptr;
    public static implicit operator D3D12_GPU_DESCRIPTOR_HANDLE(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => ptr;
    readonly object? IValueGet.GetValue() => ptr;
}
