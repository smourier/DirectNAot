#nullable enable
namespace DirectN;

public partial struct DXCoreEngineNamePropertyOutput : IEquatable<DXCoreEngineNamePropertyOutput>, IValueGet<uint>
{
    public static readonly DXCoreEngineNamePropertyOutput Null = new();
    
    public uint engineNameLength;
    
    public DXCoreEngineNamePropertyOutput(uint value) => this.engineNameLength = value;
    public override readonly string ToString() => $"0x{engineNameLength:x}";
    
    public override readonly bool Equals(object? obj) => obj is DXCoreEngineNamePropertyOutput value && Equals(value);
    public readonly bool Equals(DXCoreEngineNamePropertyOutput other) => other.engineNameLength == engineNameLength;
    public override readonly int GetHashCode() => engineNameLength.GetHashCode();
    public static bool operator ==(DXCoreEngineNamePropertyOutput left, DXCoreEngineNamePropertyOutput right) => left.Equals(right);
    public static bool operator !=(DXCoreEngineNamePropertyOutput left, DXCoreEngineNamePropertyOutput right) => !left.Equals(right);
    public static implicit operator uint(DXCoreEngineNamePropertyOutput value) => value.engineNameLength;
    public static implicit operator DXCoreEngineNamePropertyOutput(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => engineNameLength;
    readonly object? IValueGet.GetValue() => engineNameLength;
}
