#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_node_mask
public partial struct D3D12_NODE_MASK : IEquatable<D3D12_NODE_MASK>
{
    public static readonly D3D12_NODE_MASK Null = new();
    
    public uint NodeMask;
    
    public D3D12_NODE_MASK(uint value) => this.NodeMask = value;
    public override string ToString() => $"0x{NodeMask:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_NODE_MASK value && Equals(value);
    public readonly bool Equals(D3D12_NODE_MASK other) => other.NodeMask == NodeMask;
    public override readonly int GetHashCode() => NodeMask.GetHashCode();
    public static bool operator ==(D3D12_NODE_MASK left, D3D12_NODE_MASK right) => left.Equals(right);
    public static bool operator !=(D3D12_NODE_MASK left, D3D12_NODE_MASK right) => !left.Equals(right);
    public static implicit operator uint(D3D12_NODE_MASK value) => value.NodeMask;
    public static implicit operator D3D12_NODE_MASK(uint value) => new(value);
}
