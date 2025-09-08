#nullable enable
namespace DirectN;

public partial struct HMIDIOUT : IEquatable<HMIDIOUT>, IValueGet<nint>
{
    public static readonly HMIDIOUT Null = new();
    
    public nint Value;
    
    public HMIDIOUT(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIDIOUT value && Equals(value);
    public readonly bool Equals(HMIDIOUT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDIOUT left, HMIDIOUT right) => left.Equals(right);
    public static bool operator !=(HMIDIOUT left, HMIDIOUT right) => !left.Equals(right);
    public static implicit operator nint(HMIDIOUT value) => value.Value;
    public static implicit operator HMIDIOUT(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
