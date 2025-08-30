#nullable enable
namespace DirectN;

public partial struct SPGRAMMARHANDLE : IEquatable<SPGRAMMARHANDLE>, IValueGet<nint>
{
    public static readonly SPGRAMMARHANDLE Null = new();
    
    public nint Value;
    
    public SPGRAMMARHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPGRAMMARHANDLE value && Equals(value);
    public readonly bool Equals(SPGRAMMARHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Equals(right);
    public static bool operator !=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPGRAMMARHANDLE value) => value.Value;
    public static implicit operator SPGRAMMARHANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
