#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_public_key_info
public partial struct CERT_PUBLIC_KEY_INFO
{
    public CRYPT_ALGORITHM_IDENTIFIER Algorithm;
    public CRYPT_BIT_BLOB PublicKey;
}
