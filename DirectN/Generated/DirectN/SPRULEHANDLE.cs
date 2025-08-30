#nullable enable
namespace DirectN;

public partial struct SPRULEHANDLE : IEquatable<SPRULEHANDLE>, IValueGet<nint>
{
    public static readonly SPRULEHANDLE Null = new();
    
    public nint Value;
    
    public SPRULEHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPRULEHANDLE value && Equals(value);
    public readonly bool Equals(SPRULEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPRULEHANDLE left, SPRULEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPRULEHANDLE left, SPRULEHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPRULEHANDLE value) => value.Value;
    public static implicit operator SPRULEHANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
