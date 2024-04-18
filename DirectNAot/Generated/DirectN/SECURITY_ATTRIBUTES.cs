namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes
[StructLayout(LayoutKind.Sequential)]
public partial struct SECURITY_ATTRIBUTES
{
    public uint nLength;
    public nint lpSecurityDescriptor;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bInheritHandle;
}
