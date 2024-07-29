#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/gdi/colorref
public partial struct COLORREF : IEquatable<COLORREF>
{
    public static readonly COLORREF Null = new();
    
    public uint Value;
    
    public COLORREF(uint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is COLORREF value && Equals(value);
    public readonly bool Equals(COLORREF other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(COLORREF left, COLORREF right) => left.Equals(right);
    public static bool operator !=(COLORREF left, COLORREF right) => !left.Equals(right);
    public static implicit operator uint(COLORREF value) => value.Value;
    public static implicit operator COLORREF(uint value) => new(value);
}
