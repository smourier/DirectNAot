#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEPROPERTYHANDLE : IEquatable<SPPHRASEPROPERTYHANDLE>
{
    public static readonly SPPHRASEPROPERTYHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPPHRASEPROPERTYHANDLE value && Equals(value);
    public readonly bool Equals(SPPHRASEPROPERTYHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Equals(right);
    public static bool operator !=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => !left.Equals(right);
}
