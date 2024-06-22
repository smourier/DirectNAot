#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE : IEquatable<APARTMENT_SHUTDOWN_REGISTRATION_COOKIE>
{
    public static readonly APARTMENT_SHUTDOWN_REGISTRATION_COOKIE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value && Equals(value);
    public readonly bool Equals(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Equals(right);
    public static bool operator !=(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => !left.Equals(right);
}
