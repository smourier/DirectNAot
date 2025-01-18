#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypesbase/ns-wtypesbase-coauthidentity
public partial struct COAUTHIDENTITY
{
    public nint User;
    public uint UserLength;
    public nint Domain;
    public uint DomainLength;
    public nint Password;
    public uint PasswordLength;
    public uint Flags;
}
