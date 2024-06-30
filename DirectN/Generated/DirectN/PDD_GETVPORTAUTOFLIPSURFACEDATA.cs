#nullable enable
namespace DirectN;

public partial struct PDD_GETVPORTAUTOFLIPSURFACEDATA : IEquatable<PDD_GETVPORTAUTOFLIPSURFACEDATA>
{
    public static readonly PDD_GETVPORTAUTOFLIPSURFACEDATA Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is PDD_GETVPORTAUTOFLIPSURFACEDATA value && Equals(value);
    public readonly bool Equals(PDD_GETVPORTAUTOFLIPSURFACEDATA other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PDD_GETVPORTAUTOFLIPSURFACEDATA left, PDD_GETVPORTAUTOFLIPSURFACEDATA right) => left.Equals(right);
    public static bool operator !=(PDD_GETVPORTAUTOFLIPSURFACEDATA left, PDD_GETVPORTAUTOFLIPSURFACEDATA right) => !left.Equals(right);
}
