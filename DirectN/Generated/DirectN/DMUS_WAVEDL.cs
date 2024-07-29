#nullable enable
namespace DirectN;

public partial struct DMUS_WAVEDL : IEquatable<DMUS_WAVEDL>
{
    public static readonly DMUS_WAVEDL Null = new();
    
    public uint cbWaveData;
    
    public DMUS_WAVEDL(uint value) => this.cbWaveData = value;
    public override string ToString() => $"0x{cbWaveData:x}";
    
    public override readonly bool Equals(object? obj) => obj is DMUS_WAVEDL value && Equals(value);
    public readonly bool Equals(DMUS_WAVEDL other) => other.cbWaveData == cbWaveData;
    public override readonly int GetHashCode() => cbWaveData.GetHashCode();
    public static bool operator ==(DMUS_WAVEDL left, DMUS_WAVEDL right) => left.Equals(right);
    public static bool operator !=(DMUS_WAVEDL left, DMUS_WAVEDL right) => !left.Equals(right);
    public static implicit operator uint(DMUS_WAVEDL value) => value.cbWaveData;
    public static implicit operator DMUS_WAVEDL(uint value) => new(value);
}
