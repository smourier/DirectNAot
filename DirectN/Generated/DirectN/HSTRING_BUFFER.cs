#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring-buffer
public partial struct HSTRING_BUFFER : IEquatable<HSTRING_BUFFER>
{
    public static readonly HSTRING_BUFFER Null = new();
    
    public nint Value;
    
    public HSTRING_BUFFER(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HSTRING_BUFFER value && Equals(value);
    public readonly bool Equals(HSTRING_BUFFER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Equals(right);
    public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) => !left.Equals(right);
    public static implicit operator nint(HSTRING_BUFFER value) => value.Value;
    public static implicit operator HSTRING_BUFFER(nint value) => new(value);
}
