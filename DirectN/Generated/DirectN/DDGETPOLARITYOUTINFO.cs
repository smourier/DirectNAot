#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpolarityoutinfo
public partial struct DDGETPOLARITYOUTINFO : IEquatable<DDGETPOLARITYOUTINFO>
{
    public static readonly DDGETPOLARITYOUTINFO Null = new();
    
    public uint bPolarity;
    
    public DDGETPOLARITYOUTINFO(uint value) => this.bPolarity = value;
    public override string ToString() => $"0x{bPolarity:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDGETPOLARITYOUTINFO value && Equals(value);
    public readonly bool Equals(DDGETPOLARITYOUTINFO other) => other.bPolarity == bPolarity;
    public override readonly int GetHashCode() => bPolarity.GetHashCode();
    public static bool operator ==(DDGETPOLARITYOUTINFO left, DDGETPOLARITYOUTINFO right) => left.Equals(right);
    public static bool operator !=(DDGETPOLARITYOUTINFO left, DDGETPOLARITYOUTINFO right) => !left.Equals(right);
    public static implicit operator uint(DDGETPOLARITYOUTINFO value) => value.bPolarity;
    public static implicit operator DDGETPOLARITYOUTINFO(uint value) => new(value);
}
