#nullable enable
namespace DirectN;

public partial struct PCUSERIALIZEDPROPSTORAGE : IEquatable<PCUSERIALIZEDPROPSTORAGE>, IValueGet<nint>
{
    public static readonly PCUSERIALIZEDPROPSTORAGE Null = new();
    
    public nint Value;
    
    public PCUSERIALIZEDPROPSTORAGE(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PCUSERIALIZEDPROPSTORAGE value && Equals(value);
    public readonly bool Equals(PCUSERIALIZEDPROPSTORAGE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Equals(right);
    public static bool operator !=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => !left.Equals(right);
    public static implicit operator nint(PCUSERIALIZEDPROPSTORAGE value) => value.Value;
    public static implicit operator PCUSERIALIZEDPROPSTORAGE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
