#nullable enable
namespace DirectN;

public partial struct SPRECOCONTEXTHANDLE : IEquatable<SPRECOCONTEXTHANDLE>, IValueGet<nint>
{
    public static readonly SPRECOCONTEXTHANDLE Null = new();
    
    public nint Value;
    
    public SPRECOCONTEXTHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPRECOCONTEXTHANDLE value && Equals(value);
    public readonly bool Equals(SPRECOCONTEXTHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Equals(right);
    public static bool operator !=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPRECOCONTEXTHANDLE value) => value.Value;
    public static implicit operator SPRECOCONTEXTHANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
