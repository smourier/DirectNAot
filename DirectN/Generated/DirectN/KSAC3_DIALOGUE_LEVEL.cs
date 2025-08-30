#nullable enable
namespace DirectN;

public partial struct KSAC3_DIALOGUE_LEVEL : IEquatable<KSAC3_DIALOGUE_LEVEL>, IValueGet<uint>
{
    public static readonly KSAC3_DIALOGUE_LEVEL Null = new();
    
    public uint DialogueLevel;
    
    public KSAC3_DIALOGUE_LEVEL(uint value) => this.DialogueLevel = value;
    public override string ToString() => $"0x{DialogueLevel:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSAC3_DIALOGUE_LEVEL value && Equals(value);
    public readonly bool Equals(KSAC3_DIALOGUE_LEVEL other) => other.DialogueLevel == DialogueLevel;
    public override readonly int GetHashCode() => DialogueLevel.GetHashCode();
    public static bool operator ==(KSAC3_DIALOGUE_LEVEL left, KSAC3_DIALOGUE_LEVEL right) => left.Equals(right);
    public static bool operator !=(KSAC3_DIALOGUE_LEVEL left, KSAC3_DIALOGUE_LEVEL right) => !left.Equals(right);
    public static implicit operator uint(KSAC3_DIALOGUE_LEVEL value) => value.DialogueLevel;
    public static implicit operator KSAC3_DIALOGUE_LEVEL(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => DialogueLevel;
    readonly object? IValueGet.GetValue() => DialogueLevel;
}
