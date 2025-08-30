#nullable enable
namespace DirectN;

public partial struct HVIDEO : IEquatable<HVIDEO>, IValueGet<nint>
{
    public static readonly HVIDEO Null = new();
    
    public nint Value;
    
    public HVIDEO(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HVIDEO value && Equals(value);
    public readonly bool Equals(HVIDEO other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HVIDEO left, HVIDEO right) => left.Equals(right);
    public static bool operator !=(HVIDEO left, HVIDEO right) => !left.Equals(right);
    public static implicit operator nint(HVIDEO value) => value.Value;
    public static implicit operator HVIDEO(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
