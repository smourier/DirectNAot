#nullable enable
namespace DirectN;

public partial struct HWND : IEquatable<HWND>, IValueGet<nint>
{
    public static readonly HWND Null = new();
    
    public nint Value;
    
    public HWND(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HWND value && Equals(value);
    public readonly bool Equals(HWND other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWND left, HWND right) => left.Equals(right);
    public static bool operator !=(HWND left, HWND right) => !left.Equals(right);
    public static implicit operator nint(HWND value) => value.Value;
    public static implicit operator HWND(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
