#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinAuto/hwineventhook
public partial struct HWINEVENTHOOK : IEquatable<HWINEVENTHOOK>, IValueGet<nint>
{
    public static readonly HWINEVENTHOOK Null = new();
    
    public nint Value;
    
    public HWINEVENTHOOK(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HWINEVENTHOOK value && Equals(value);
    public readonly bool Equals(HWINEVENTHOOK other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Equals(right);
    public static bool operator !=(HWINEVENTHOOK left, HWINEVENTHOOK right) => !left.Equals(right);
    public static implicit operator nint(HWINEVENTHOOK value) => value.Value;
    public static implicit operator HWINEVENTHOOK(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
