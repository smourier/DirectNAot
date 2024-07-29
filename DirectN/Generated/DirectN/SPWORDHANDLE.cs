#nullable enable
namespace DirectN;

public partial struct SPWORDHANDLE : IEquatable<SPWORDHANDLE>
{
    public static readonly SPWORDHANDLE Null = new();
    
    public nint Value;
    
    public SPWORDHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPWORDHANDLE value && Equals(value);
    public readonly bool Equals(SPWORDHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPWORDHANDLE left, SPWORDHANDLE right) => left.Equals(right);
    public static bool operator !=(SPWORDHANDLE left, SPWORDHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPWORDHANDLE value) => value.Value;
    public static implicit operator SPWORDHANDLE(nint value) => new(value);
}
