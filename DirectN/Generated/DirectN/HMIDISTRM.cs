#nullable enable
namespace DirectN;

public partial struct HMIDISTRM : IEquatable<HMIDISTRM>, IValueGet<nint>
{
    public static readonly HMIDISTRM Null = new();
    
    public nint Value;
    
    public HMIDISTRM(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIDISTRM value && Equals(value);
    public readonly bool Equals(HMIDISTRM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDISTRM left, HMIDISTRM right) => left.Equals(right);
    public static bool operator !=(HMIDISTRM left, HMIDISTRM right) => !left.Equals(right);
    public static implicit operator nint(HMIDISTRM value) => value.Value;
    public static implicit operator HMIDISTRM(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
