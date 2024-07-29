#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-palobj
public partial struct PALOBJ : IEquatable<PALOBJ>
{
    public static readonly PALOBJ Null = new();
    
    public uint ulReserved;
    
    public PALOBJ(uint value) => this.ulReserved = value;
    public override string ToString() => $"0x{ulReserved:x}";
    
    public override readonly bool Equals(object? obj) => obj is PALOBJ value && Equals(value);
    public readonly bool Equals(PALOBJ other) => other.ulReserved == ulReserved;
    public override readonly int GetHashCode() => ulReserved.GetHashCode();
    public static bool operator ==(PALOBJ left, PALOBJ right) => left.Equals(right);
    public static bool operator !=(PALOBJ left, PALOBJ right) => !left.Equals(right);
    public static implicit operator uint(PALOBJ value) => value.ulReserved;
    public static implicit operator PALOBJ(uint value) => new(value);
}
