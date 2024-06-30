﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring
public partial struct HSTRING : IEquatable<HSTRING>
{
    public static readonly HSTRING Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HSTRING value && Equals(value);
    public readonly bool Equals(HSTRING other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSTRING left, HSTRING right) => left.Equals(right);
    public static bool operator !=(HSTRING left, HSTRING right) => !left.Equals(right);
}
