#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_context
public partial struct CERT_CONTEXT
{
    public CERT_QUERY_ENCODING_TYPE dwCertEncodingType;
    public nint pbCertEncoded;
    public uint cbCertEncoded;
    public nint pCertInfo;
    public HCERTSTORE hCertStore;
}
