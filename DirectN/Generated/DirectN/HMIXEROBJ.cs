#nullable enable
namespace DirectN;

public partial struct HMIXEROBJ : IEquatable<HMIXEROBJ>, IValueGet<nint>
{
    public static readonly HMIXEROBJ Null = new();
    
    public nint Value;
    
    public HMIXEROBJ(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIXEROBJ value && Equals(value);
    public readonly bool Equals(HMIXEROBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Equals(right);
    public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => !left.Equals(right);
    public static implicit operator nint(HMIXEROBJ value) => value.Value;
    public static implicit operator HMIXEROBJ(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
