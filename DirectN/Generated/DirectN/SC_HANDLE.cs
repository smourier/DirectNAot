#nullable enable
namespace DirectN;

public partial struct SC_HANDLE : IEquatable<SC_HANDLE>, IValueGet<nint>
{
    public static readonly SC_HANDLE Null = new();
    
    public nint Value;
    
    public SC_HANDLE(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SC_HANDLE value && Equals(value);
    public readonly bool Equals(SC_HANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SC_HANDLE left, SC_HANDLE right) => left.Equals(right);
    public static bool operator !=(SC_HANDLE left, SC_HANDLE right) => !left.Equals(right);
    public static implicit operator nint(SC_HANDLE value) => value.Value;
    public static implicit operator SC_HANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
