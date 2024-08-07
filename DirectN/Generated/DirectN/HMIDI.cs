﻿#nullable enable
namespace DirectN;

public partial struct HMIDI : IEquatable<HMIDI>
{
    public static readonly HMIDI Null = new();
    
    public nint Value;
    
    public HMIDI(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIDI value && Equals(value);
    public readonly bool Equals(HMIDI other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDI left, HMIDI right) => left.Equals(right);
    public static bool operator !=(HMIDI left, HMIDI right) => !left.Equals(right);
    public static implicit operator nint(HMIDI value) => value.Value;
    public static implicit operator HMIDI(nint value) => new(value);
}
