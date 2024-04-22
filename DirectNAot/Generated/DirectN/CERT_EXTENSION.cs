namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_extension
[StructLayout(LayoutKind.Sequential)]
public partial struct CERT_EXTENSION
{
    public PSTR pszObjId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCritical;
    public CRYPT_INTEGER_BLOB Value;
}
