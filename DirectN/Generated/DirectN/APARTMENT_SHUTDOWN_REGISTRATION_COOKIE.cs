#nullable enable
namespace DirectN;

public partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE : IEquatable<APARTMENT_SHUTDOWN_REGISTRATION_COOKIE>
{
    public static readonly APARTMENT_SHUTDOWN_REGISTRATION_COOKIE Null = new();
    
    public nint Value;
    
    public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value && Equals(value);
    public readonly bool Equals(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Equals(right);
    public static bool operator !=(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => !left.Equals(right);
    public static implicit operator nint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => value.Value;
    public static implicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value) => new(value);
}
