#nullable enable
namespace DirectN;

public partial struct AM_AC3_DIALOGUE_LEVEL : IEquatable<AM_AC3_DIALOGUE_LEVEL>, IValueGet<uint>
{
    public static readonly AM_AC3_DIALOGUE_LEVEL Null = new();
    
    public uint DialogueLevel;
    
    public AM_AC3_DIALOGUE_LEVEL(uint value) => this.DialogueLevel = value;
    public override readonly string ToString() => $"0x{DialogueLevel:x}";
    
    public override readonly bool Equals(object? obj) => obj is AM_AC3_DIALOGUE_LEVEL value && Equals(value);
    public readonly bool Equals(AM_AC3_DIALOGUE_LEVEL other) => other.DialogueLevel == DialogueLevel;
    public override readonly int GetHashCode() => DialogueLevel.GetHashCode();
    public static bool operator ==(AM_AC3_DIALOGUE_LEVEL left, AM_AC3_DIALOGUE_LEVEL right) => left.Equals(right);
    public static bool operator !=(AM_AC3_DIALOGUE_LEVEL left, AM_AC3_DIALOGUE_LEVEL right) => !left.Equals(right);
    public static implicit operator uint(AM_AC3_DIALOGUE_LEVEL value) => value.DialogueLevel;
    public static implicit operator AM_AC3_DIALOGUE_LEVEL(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => DialogueLevel;
    readonly object? IValueGet.GetValue() => DialogueLevel;
}
