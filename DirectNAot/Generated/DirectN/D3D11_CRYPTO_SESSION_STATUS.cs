namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ne-d3d11_1-d3d11_crypto_session_status
public enum D3D11_CRYPTO_SESSION_STATUS
{
    D3D11_CRYPTO_SESSION_STATUS_OK = 0,
    D3D11_CRYPTO_SESSION_STATUS_KEY_LOST = 1,
    D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST = 2,
}
