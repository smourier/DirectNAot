#nullable enable
namespace DirectN;

public partial struct SPSTATEHANDLE : IEquatable<SPSTATEHANDLE>, IValueGet<nint>
{
    public static readonly SPSTATEHANDLE Null = new();
    
    public nint Value;
    
    public SPSTATEHANDLE(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPSTATEHANDLE value && Equals(value);
    public readonly bool Equals(SPSTATEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPSTATEHANDLE value) => value.Value;
    public static implicit operator SPSTATEHANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
