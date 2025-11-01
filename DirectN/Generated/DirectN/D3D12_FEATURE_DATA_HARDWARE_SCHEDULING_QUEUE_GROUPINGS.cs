#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS : IEquatable<D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS>, IValueGet<uint>
{
    public static readonly D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS Null = new();
    
    public uint ComputeQueuesPer3DQueue;
    
    public D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS(uint value) => this.ComputeQueuesPer3DQueue = value;
    public override readonly string ToString() => $"0x{ComputeQueuesPer3DQueue:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS value && Equals(value);
    public readonly bool Equals(D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS other) => other.ComputeQueuesPer3DQueue == ComputeQueuesPer3DQueue;
    public override readonly int GetHashCode() => ComputeQueuesPer3DQueue.GetHashCode();
    public static bool operator ==(D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS left, D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS right) => left.Equals(right);
    public static bool operator !=(D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS left, D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS right) => !left.Equals(right);
    public static implicit operator uint(D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS value) => value.ComputeQueuesPer3DQueue;
    public static implicit operator D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => ComputeQueuesPer3DQueue;
    readonly object? IValueGet.GetValue() => ComputeQueuesPer3DQueue;
}
