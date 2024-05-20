#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/ro-registration-cookie
[StructLayout(LayoutKind.Sequential)]
public partial struct RO_REGISTRATION_COOKIE
{
    public static readonly RO_REGISTRATION_COOKIE Null = new();
    
    public nint Value;
}
