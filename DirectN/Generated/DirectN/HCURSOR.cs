﻿#nullable enable
namespace DirectN;

public partial struct HCURSOR : IEquatable<HCURSOR>
{
    public static readonly HCURSOR Null = new();
    
    public nint Value;
    
    public HCURSOR(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HCURSOR value && Equals(value);
    public readonly bool Equals(HCURSOR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCURSOR left, HCURSOR right) => left.Equals(right);
    public static bool operator !=(HCURSOR left, HCURSOR right) => !left.Equals(right);
    public static implicit operator nint(HCURSOR value) => value.Value;
    public static implicit operator HCURSOR(nint value) => new(value);
}
