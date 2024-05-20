#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_algorithm_identifier
[StructLayout(LayoutKind.Sequential)]
public partial struct CRYPT_ALGORITHM_IDENTIFIER
{
    public PSTR pszObjId;
    public CRYPT_INTEGER_BLOB Parameters;
}
