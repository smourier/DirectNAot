#nullable enable
namespace DirectN;

public partial struct HMIDIIN : IEquatable<HMIDIIN>, IValueGet<nint>
{
    public static readonly HMIDIIN Null = new();
    
    public nint Value;
    
    public HMIDIIN(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIDIIN value && Equals(value);
    public readonly bool Equals(HMIDIIN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Equals(right);
    public static bool operator !=(HMIDIIN left, HMIDIIN right) => !left.Equals(right);
    public static implicit operator nint(HMIDIIN value) => value.Value;
    public static implicit operator HMIDIIN(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
