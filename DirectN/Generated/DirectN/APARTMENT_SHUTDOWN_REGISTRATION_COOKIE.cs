#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE
{
    public static readonly APARTMENT_SHUTDOWN_REGISTRATION_COOKIE Null = new();
    
    public nint Value;
}
