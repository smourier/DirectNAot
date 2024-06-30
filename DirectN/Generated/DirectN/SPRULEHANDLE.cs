﻿#nullable enable
namespace DirectN;

public partial struct SPRULEHANDLE : IEquatable<SPRULEHANDLE>
{
    public static readonly SPRULEHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPRULEHANDLE value && Equals(value);
    public readonly bool Equals(SPRULEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPRULEHANDLE left, SPRULEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPRULEHANDLE left, SPRULEHANDLE right) => !left.Equals(right);
}
