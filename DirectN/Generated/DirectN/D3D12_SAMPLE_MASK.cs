#nullable enable
namespace DirectN;

public partial struct D3D12_SAMPLE_MASK : IEquatable<D3D12_SAMPLE_MASK>
{
    public static readonly D3D12_SAMPLE_MASK Null = new();
    
    public uint SampleMask;
    
    public D3D12_SAMPLE_MASK(uint value) => this.SampleMask = value;
    public override string ToString() => $"0x{SampleMask:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_SAMPLE_MASK value && Equals(value);
    public readonly bool Equals(D3D12_SAMPLE_MASK other) => other.SampleMask == SampleMask;
    public override readonly int GetHashCode() => SampleMask.GetHashCode();
    public static bool operator ==(D3D12_SAMPLE_MASK left, D3D12_SAMPLE_MASK right) => left.Equals(right);
    public static bool operator !=(D3D12_SAMPLE_MASK left, D3D12_SAMPLE_MASK right) => !left.Equals(right);
    public static implicit operator uint(D3D12_SAMPLE_MASK value) => value.SampleMask;
    public static implicit operator D3D12_SAMPLE_MASK(uint value) => new(value);
}
