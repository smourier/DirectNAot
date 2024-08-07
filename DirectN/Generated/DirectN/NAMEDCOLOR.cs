﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-namedcolor
public partial struct NAMEDCOLOR : IEquatable<NAMEDCOLOR>
{
    public static readonly NAMEDCOLOR Null = new();
    
    public uint dwIndex;
    
    public NAMEDCOLOR(uint value) => this.dwIndex = value;
    public override string ToString() => $"0x{dwIndex:x}";
    
    public override readonly bool Equals(object? obj) => obj is NAMEDCOLOR value && Equals(value);
    public readonly bool Equals(NAMEDCOLOR other) => other.dwIndex == dwIndex;
    public override readonly int GetHashCode() => dwIndex.GetHashCode();
    public static bool operator ==(NAMEDCOLOR left, NAMEDCOLOR right) => left.Equals(right);
    public static bool operator !=(NAMEDCOLOR left, NAMEDCOLOR right) => !left.Equals(right);
    public static implicit operator uint(NAMEDCOLOR value) => value.dwIndex;
    public static implicit operator NAMEDCOLOR(uint value) => new(value);
}
