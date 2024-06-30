#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_palette_global
public partial struct DD_PALETTE_GLOBAL : IEquatable<DD_PALETTE_GLOBAL>
{
    public static readonly DD_PALETTE_GLOBAL Null = new();
    
    public nuint dwReserved1;
    
    public override readonly bool Equals(object? obj) => obj is DD_PALETTE_GLOBAL value && Equals(value);
    public readonly bool Equals(DD_PALETTE_GLOBAL other) => other.dwReserved1 == dwReserved1;
    public override readonly int GetHashCode() => dwReserved1.GetHashCode();
    public static bool operator ==(DD_PALETTE_GLOBAL left, DD_PALETTE_GLOBAL right) => left.Equals(right);
    public static bool operator !=(DD_PALETTE_GLOBAL left, DD_PALETTE_GLOBAL right) => !left.Equals(right);
}
