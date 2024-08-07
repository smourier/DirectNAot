﻿#nullable enable
namespace DirectN;

public partial struct HTASK : IEquatable<HTASK>
{
    public static readonly HTASK Null = new();
    
    public nint Value;
    
    public HTASK(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HTASK value && Equals(value);
    public readonly bool Equals(HTASK other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HTASK left, HTASK right) => left.Equals(right);
    public static bool operator !=(HTASK left, HTASK right) => !left.Equals(right);
    public static implicit operator nint(HTASK value) => value.Value;
    public static implicit operator HTASK(nint value) => new(value);
}
