#nullable enable
namespace DirectN;

public partial struct KSJACK_DESCRIPTION3 : IEquatable<KSJACK_DESCRIPTION3>
{
    public static readonly KSJACK_DESCRIPTION3 Null = new();
    
    public uint ConfigId;
    
    public KSJACK_DESCRIPTION3(uint value) => this.ConfigId = value;
    public override string ToString() => $"0x{ConfigId:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSJACK_DESCRIPTION3 value && Equals(value);
    public readonly bool Equals(KSJACK_DESCRIPTION3 other) => other.ConfigId == ConfigId;
    public override readonly int GetHashCode() => ConfigId.GetHashCode();
    public static bool operator ==(KSJACK_DESCRIPTION3 left, KSJACK_DESCRIPTION3 right) => left.Equals(right);
    public static bool operator !=(KSJACK_DESCRIPTION3 left, KSJACK_DESCRIPTION3 right) => !left.Equals(right);
    public static implicit operator uint(KSJACK_DESCRIPTION3 value) => value.ConfigId;
    public static implicit operator KSJACK_DESCRIPTION3(uint value) => new(value);
}
