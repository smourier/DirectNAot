#nullable enable
namespace DirectN;

public partial struct SERIALIZEDPROPSTORAGE : IEquatable<SERIALIZEDPROPSTORAGE>, IValueGet<nint>
{
    public static readonly SERIALIZEDPROPSTORAGE Null = new();
    
    public nint Value;
    
    public SERIALIZEDPROPSTORAGE(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SERIALIZEDPROPSTORAGE value && Equals(value);
    public readonly bool Equals(SERIALIZEDPROPSTORAGE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SERIALIZEDPROPSTORAGE left, SERIALIZEDPROPSTORAGE right) => left.Equals(right);
    public static bool operator !=(SERIALIZEDPROPSTORAGE left, SERIALIZEDPROPSTORAGE right) => !left.Equals(right);
    public static implicit operator nint(SERIALIZEDPROPSTORAGE value) => value.Value;
    public static implicit operator SERIALIZEDPROPSTORAGE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
