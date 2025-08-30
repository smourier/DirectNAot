#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S : IEquatable<KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S>, IValueGet<uint>
{
    public static readonly KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S Null = new();
    
    public uint InterleavedCapPossible;
    
    public KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S(uint value) => this.InterleavedCapPossible = value;
    public override string ToString() => $"0x{InterleavedCapPossible:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S value && Equals(value);
    public readonly bool Equals(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S other) => other.InterleavedCapPossible == InterleavedCapPossible;
    public override readonly int GetHashCode() => InterleavedCapPossible.GetHashCode();
    public static bool operator ==(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S left, KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S right) => left.Equals(right);
    public static bool operator !=(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S left, KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S right) => !left.Equals(right);
    public static implicit operator uint(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S value) => value.InterleavedCapPossible;
    public static implicit operator KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => InterleavedCapPossible;
    readonly object? IValueGet.GetValue() => InterleavedCapPossible;
}
