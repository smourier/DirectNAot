#nullable enable
namespace DirectN;

public partial struct SPPHRASEPROPERTYHANDLE : IEquatable<SPPHRASEPROPERTYHANDLE>
{
    public static readonly SPPHRASEPROPERTYHANDLE Null = new();
    
    public nint Value;
    
    public SPPHRASEPROPERTYHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPPHRASEPROPERTYHANDLE value && Equals(value);
    public readonly bool Equals(SPPHRASEPROPERTYHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Equals(right);
    public static bool operator !=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPPHRASEPROPERTYHANDLE value) => value.Value;
    public static implicit operator SPPHRASEPROPERTYHANDLE(nint value) => new(value);
}
