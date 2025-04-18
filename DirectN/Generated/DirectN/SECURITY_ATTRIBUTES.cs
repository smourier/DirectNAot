#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes
public partial struct SECURITY_ATTRIBUTES
{
    public uint nLength;
    public nint lpSecurityDescriptor;
    public BOOL bInheritHandle;
}
