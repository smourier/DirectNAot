#nullable enable
namespace DirectN;

public partial struct PDD_DESTROYDRIVERDATA : IEquatable<PDD_DESTROYDRIVERDATA>
{
    public static readonly PDD_DESTROYDRIVERDATA Null = new();
    
    public nint Value;
    
    public PDD_DESTROYDRIVERDATA(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PDD_DESTROYDRIVERDATA value && Equals(value);
    public readonly bool Equals(PDD_DESTROYDRIVERDATA other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PDD_DESTROYDRIVERDATA left, PDD_DESTROYDRIVERDATA right) => left.Equals(right);
    public static bool operator !=(PDD_DESTROYDRIVERDATA left, PDD_DESTROYDRIVERDATA right) => !left.Equals(right);
    public static implicit operator nint(PDD_DESTROYDRIVERDATA value) => value.Value;
    public static implicit operator PDD_DESTROYDRIVERDATA(nint value) => new(value);
}
