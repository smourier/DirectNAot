#nullable enable
namespace DirectN;

public partial struct HWAVEOUT : IEquatable<HWAVEOUT>, IValueGet<nint>
{
    public static readonly HWAVEOUT Null = new();
    
    public nint Value;
    
    public HWAVEOUT(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HWAVEOUT value && Equals(value);
    public readonly bool Equals(HWAVEOUT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Equals(right);
    public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => !left.Equals(right);
    public static implicit operator nint(HWAVEOUT value) => value.Value;
    public static implicit operator HWAVEOUT(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
