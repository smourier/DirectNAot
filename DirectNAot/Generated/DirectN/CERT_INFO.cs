namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_info
[StructLayout(LayoutKind.Sequential)]
public partial struct CERT_INFO
{
    public uint dwVersion;
    public CRYPT_INTEGER_BLOB SerialNumber;
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;
    public CRYPT_INTEGER_BLOB Issuer;
    public FILETIME NotBefore;
    public FILETIME NotAfter;
    public CRYPT_INTEGER_BLOB Subject;
    public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;
    public CRYPT_BIT_BLOB IssuerUniqueId;
    public CRYPT_BIT_BLOB SubjectUniqueId;
    public uint cExtension;
    public nint rgExtension;
}
