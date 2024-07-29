#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-xformobj
public partial struct XFORMOBJ : IEquatable<XFORMOBJ>
{
    public static readonly XFORMOBJ Null = new();
    
    public uint ulReserved;
    
    public XFORMOBJ(uint value) => this.ulReserved = value;
    public override string ToString() => $"0x{ulReserved:x}";
    
    public override readonly bool Equals(object? obj) => obj is XFORMOBJ value && Equals(value);
    public readonly bool Equals(XFORMOBJ other) => other.ulReserved == ulReserved;
    public override readonly int GetHashCode() => ulReserved.GetHashCode();
    public static bool operator ==(XFORMOBJ left, XFORMOBJ right) => left.Equals(right);
    public static bool operator !=(XFORMOBJ left, XFORMOBJ right) => !left.Equals(right);
    public static implicit operator uint(XFORMOBJ value) => value.ulReserved;
    public static implicit operator XFORMOBJ(uint value) => new(value);
}
