﻿#nullable enable
namespace DirectN;

public partial struct HMONITOR : IEquatable<HMONITOR>
{
    public static readonly HMONITOR Null = new();
    
    public nint Value;
    
    public HMONITOR(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMONITOR value && Equals(value);
    public readonly bool Equals(HMONITOR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMONITOR left, HMONITOR right) => left.Equals(right);
    public static bool operator !=(HMONITOR left, HMONITOR right) => !left.Equals(right);
    public static implicit operator nint(HMONITOR value) => value.Value;
    public static implicit operator HMONITOR(nint value) => new(value);
}
