﻿#nullable enable
namespace DirectN;

public partial struct HCERTSTORE : IEquatable<HCERTSTORE>
{
    public static readonly HCERTSTORE Null = new();
    
    public nint Value;
    
    public HCERTSTORE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HCERTSTORE value && Equals(value);
    public readonly bool Equals(HCERTSTORE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCERTSTORE left, HCERTSTORE right) => left.Equals(right);
    public static bool operator !=(HCERTSTORE left, HCERTSTORE right) => !left.Equals(right);
    public static implicit operator nint(HCERTSTORE value) => value.Value;
    public static implicit operator HCERTSTORE(nint value) => new(value);
}
