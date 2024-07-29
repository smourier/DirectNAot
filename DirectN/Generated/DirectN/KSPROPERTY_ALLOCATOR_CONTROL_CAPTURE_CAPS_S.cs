#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S : IEquatable<KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S>
{
    public static readonly KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S Null = new();
    
    public uint InterleavedCapSupported;
    
    public KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S(uint value) => this.InterleavedCapSupported = value;
    public override string ToString() => $"0x{InterleavedCapSupported:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S value && Equals(value);
    public readonly bool Equals(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S other) => other.InterleavedCapSupported == InterleavedCapSupported;
    public override readonly int GetHashCode() => InterleavedCapSupported.GetHashCode();
    public static bool operator ==(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S left, KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S right) => left.Equals(right);
    public static bool operator !=(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S left, KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S right) => !left.Equals(right);
    public static implicit operator uint(KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S value) => value.InterleavedCapSupported;
    public static implicit operator KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S(uint value) => new(value);
}
