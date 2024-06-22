#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring-buffer
[StructLayout(LayoutKind.Sequential)]
public partial struct HSTRING_BUFFER : IEquatable<HSTRING_BUFFER>
{
    public static readonly HSTRING_BUFFER Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HSTRING_BUFFER value && Equals(value);
    public readonly bool Equals(HSTRING_BUFFER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Equals(right);
    public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) => !left.Equals(right);
}
