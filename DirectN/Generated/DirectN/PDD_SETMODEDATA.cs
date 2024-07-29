#nullable enable
namespace DirectN;

public partial struct PDD_SETMODEDATA : IEquatable<PDD_SETMODEDATA>
{
    public static readonly PDD_SETMODEDATA Null = new();
    
    public nint Value;
    
    public PDD_SETMODEDATA(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PDD_SETMODEDATA value && Equals(value);
    public readonly bool Equals(PDD_SETMODEDATA other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PDD_SETMODEDATA left, PDD_SETMODEDATA right) => left.Equals(right);
    public static bool operator !=(PDD_SETMODEDATA left, PDD_SETMODEDATA right) => !left.Equals(right);
    public static implicit operator nint(PDD_SETMODEDATA value) => value.Value;
    public static implicit operator PDD_SETMODEDATA(nint value) => new(value);
}
