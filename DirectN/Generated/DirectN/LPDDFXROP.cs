#nullable enable
namespace DirectN;

public partial struct LPDDFXROP : IEquatable<LPDDFXROP>, IValueGet<nint>
{
    public static readonly LPDDFXROP Null = new();
    
    public nint Value;
    
    public LPDDFXROP(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is LPDDFXROP value && Equals(value);
    public readonly bool Equals(LPDDFXROP other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(LPDDFXROP left, LPDDFXROP right) => left.Equals(right);
    public static bool operator !=(LPDDFXROP left, LPDDFXROP right) => !left.Equals(right);
    public static implicit operator nint(LPDDFXROP value) => value.Value;
    public static implicit operator LPDDFXROP(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
