#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/ro-registration-cookie
public partial struct RO_REGISTRATION_COOKIE : IEquatable<RO_REGISTRATION_COOKIE>, IValueGet<nint>
{
    public static readonly RO_REGISTRATION_COOKIE Null = new();
    
    public nint Value;
    
    public RO_REGISTRATION_COOKIE(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is RO_REGISTRATION_COOKIE value && Equals(value);
    public readonly bool Equals(RO_REGISTRATION_COOKIE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(RO_REGISTRATION_COOKIE left, RO_REGISTRATION_COOKIE right) => left.Equals(right);
    public static bool operator !=(RO_REGISTRATION_COOKIE left, RO_REGISTRATION_COOKIE right) => !left.Equals(right);
    public static implicit operator nint(RO_REGISTRATION_COOKIE value) => value.Value;
    public static implicit operator RO_REGISTRATION_COOKIE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
