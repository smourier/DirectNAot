#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_extension
public partial struct CERT_EXTENSION
{
    public PSTR pszObjId;
    public BOOL fCritical;
    public CRYPT_INTEGER_BLOB Value;
}
