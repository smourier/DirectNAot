#nullable enable
namespace DirectN;

public partial struct HANDLE : IEquatable<HANDLE>, IValueGet<nint>
{
    public static readonly HANDLE Null = new();
    
    public nint Value;
    
    public HANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HANDLE value && Equals(value);
    public readonly bool Equals(HANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HANDLE left, HANDLE right) => left.Equals(right);
    public static bool operator !=(HANDLE left, HANDLE right) => !left.Equals(right);
    public static implicit operator nint(HANDLE value) => value.Value;
    public static implicit operator HANDLE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
