#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dpapi/ns-dpapi-crypt_integer_blob
[StructLayout(LayoutKind.Sequential)]
public partial struct CRYPT_INTEGER_BLOB
{
    public uint cbData;
    public nint pbData;
}
