﻿#nullable enable
namespace DirectN;

public partial struct HBITMAP : IEquatable<HBITMAP>
{
    public static readonly HBITMAP Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HBITMAP value && Equals(value);
    public readonly bool Equals(HBITMAP other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HBITMAP left, HBITMAP right) => left.Equals(right);
    public static bool operator !=(HBITMAP left, HBITMAP right) => !left.Equals(right);
}
