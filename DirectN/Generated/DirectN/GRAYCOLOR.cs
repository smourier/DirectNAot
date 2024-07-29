#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-graycolor
public partial struct GRAYCOLOR : IEquatable<GRAYCOLOR>
{
    public static readonly GRAYCOLOR Null = new();
    
    public ushort gray;
    
    public GRAYCOLOR(ushort value) => this.gray = value;
    public override string ToString() => $"0x{gray:x}";
    
    public override readonly bool Equals(object? obj) => obj is GRAYCOLOR value && Equals(value);
    public readonly bool Equals(GRAYCOLOR other) => other.gray == gray;
    public override readonly int GetHashCode() => gray.GetHashCode();
    public static bool operator ==(GRAYCOLOR left, GRAYCOLOR right) => left.Equals(right);
    public static bool operator !=(GRAYCOLOR left, GRAYCOLOR right) => !left.Equals(right);
    public static implicit operator ushort(GRAYCOLOR value) => value.gray;
    public static implicit operator GRAYCOLOR(ushort value) => new(value);
}
