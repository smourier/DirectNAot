﻿#nullable enable
namespace DirectN;

public partial struct BOOLEAN : IEquatable<BOOLEAN>
{
    public static readonly BOOLEAN Null = new();
    
    public byte Value;
    
    public BOOLEAN(byte value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is BOOLEAN value && Equals(value);
    public readonly bool Equals(BOOLEAN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(BOOLEAN left, BOOLEAN right) => left.Equals(right);
    public static bool operator !=(BOOLEAN left, BOOLEAN right) => !left.Equals(right);
    public static implicit operator byte(BOOLEAN value) => value.Value;
    public static implicit operator BOOLEAN(byte value) => new(value);
}
